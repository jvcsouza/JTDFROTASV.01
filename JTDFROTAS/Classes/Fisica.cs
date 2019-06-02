using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    public class Fisica : Pessoa
    {
        private int id;
        private String cpf;
        private int codPessoa;
        private int codCidade;
        private String logradouro;
        private String num;
        private String nome;

        public Fisica(String nome, String logradouro, String num, int codCidade, String cpf, object fones)
            : base(nome, logradouro, num, codCidade, fones)
        {
            Cpf = cpf;
        }

        public Fisica(int id, String nome, String logradouro, String num, int codCidade, String cpf, int codPessoa)
            : base(id, nome, logradouro, num, codCidade)
        {
            codPessoa = id;
            Cpf = cpf;
        }

        public Fisica(int id, int codP, String nome, String logradouro, String num, int codCidade, String cpf, int codPessoa)
            : base(codP, nome, logradouro, num, codCidade)
        {
            IdFisica = id;
            codPessoa = codP;
            Cpf = cpf;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public int CodCidade { get => codCidade; set => codCidade = value; }
        public int IdFisica { get => id; set => id = value; }

        public override bool Registrar()
        {
            base.Registrar();
            codPessoa = Id;

            return true;
        }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = $"SELECT F.ID, P.NOME, F.CPF, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                            $" FROM PESSOA P" +
                            $" RIGHT JOIN FISICA F" +
                            $" ON F.CODPESSOA = P.ID" +
                            $" INNER JOIN CIDADE C" +
                            $" ON C.ID = P.CODCIDADE WHERE P.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = $"SELECT F.ID, P.NOME, F.CPF, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                            $" FROM PESSOA P" +
                            $" RIGHT JOIN FISICA F" +
                            $" ON F.CODPESSOA = P.ID" +
                            $" INNER JOIN CIDADE C" +
                            $" ON C.ID = P.CODCIDADE";
            return Conexao.ExecAdapter();
        }
        public static DataTable ListarBusca(String nome)
        {
            Conexao.Query = $"SELECT F.ID, P.NOME, F.CPF, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                           $" FROM PESSOA P" +
                           $" RIGHT JOIN FISICA F" +
                           $" ON F.CODPESSOA = P.ID" +
                           $" INNER JOIN CIDADE C" +
                           $" ON C.ID = P.CODCIDADE" +
                           $" WHERE P.NOME LIKE '%{nome}%'";
            return Conexao.ExecAdapter();
        }
        public static DataTable ListarBusca(String nome, bool ativo)
        {
            Conexao.Query = $"SELECT F.ID, P.NOME, F.CPF, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                           $" FROM PESSOA P" +
                           $" RIGHT JOIN FISICA F" +
                           $" ON F.CODPESSOA = P.ID" +
                           $" INNER JOIN CIDADE C" +
                           $" ON C.ID = P.CODCIDADE" +
                           $" WHERE P.NOME LIKE '%{nome}%'" +
                           $" AND P.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
    }
}
