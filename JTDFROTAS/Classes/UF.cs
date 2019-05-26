using System;
using System.Data;

namespace JTDFROTAS.Classes
{
    public class UF : ICRUD
    {
        private int id;
        private String nome;
        private String sigla;

        public String Nome
        {
            get { return nome.ToUpper(); }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new FormatException($"Valor atribuido ao campo *{nameof(nome)}* é inválido!");
                nome = value.ToUpper();
            }
        }
        public String Sigla
        {
            get { return sigla.ToUpper(); }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new FormatException($"Valor atribuido ao campo *{nameof(sigla)}* é inválido!");
                sigla = value.ToUpper();
            }
        }

        public int Id { get => id; set => id = value; }

        public UF(String nome, String sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public UF(int id, String nome, String sigla)
        {
            this.Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT ID, NOME, UF AS SIGLA 
                            FROM UF
                            WHERE ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }

        public static DataTable Listar()
        {
            Conexao.Query = @"SELECT ID, NOME, UF AS SIGLA FROM UF";
            return Conexao.ExecAdapter();
        }

        public bool Registrar()
        {
            throw new NotImplementedException();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
