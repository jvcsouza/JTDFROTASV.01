using System;
using System.Data;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class UF : ICRUD
    {
        private int id;
        private String nome;
        private String sigla;
        private bool ativo;

        public String Nome
        {
            get { return nome.ToUpper(); }
            set
            {
                //if (String.IsNullOrWhiteSpace(value))
                //    throw new FormatException($"Valor atribuido ao campo *{nameof(nome)}* é inválido!");
                nome = value;
            }
        }
        public String Sigla
        {
            get { return sigla.ToUpper(); }
            set
            {
                //if (String.IsNullOrWhiteSpace(value))
                //    throw new FormatException($"Valor atribuido ao campo *{nameof(sigla)}* é inválido!");
                sigla = value;
            }
        }

        public int Id { get => id; set => id = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public UF(String nome, String sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public UF(int id, String nome, String sigla, bool ativo)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
            Ativo = ativo;
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

        public static UF Buscar(int id)
        {
            UF u;
            Conexao.Query = $"SELECT * FROM UF"
                            + " WHERE ID = " + id
                            + " AND ATIVO = 1";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr.Read())
                u = new UF((int)dr["id"], dr["nome"].ToString(), dr["uf"].ToString(), (bool)dr["ativo"]);
            else
                u = new UF(0, "", "", false);
            dr.Close();
            return u;
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

        bool ICRUD.Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
