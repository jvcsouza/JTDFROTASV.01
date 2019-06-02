using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace JTDFROTAS.Classes
{
    class Juridica : Pessoa
    {
        private String cnpj;
        private int codPessoaJuridica;
        private String fantasia, atividade;

        public String Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                String valor = Regex.Replace(value, "[^0-9]", "");
                if (valor.Length != 14)
                    throw new ArgumentException("Valores não correspondem a um CNPJ Válido!");
                cnpj = value;
            }
        }

        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Atividade { get => atividade; set => atividade = value; }
        public int CodPessoaJuridica { get => codPessoaJuridica; set => codPessoaJuridica = value; }

        public Juridica(String nome, String logradouro, String num, int codCidade, String cnpj, String fantasia, String atividade)
            : base(nome, logradouro, num, codCidade)
        {
            Fantasia = fantasia;
            Atividade = atividade;
            Cnpj = cnpj;
        }
        public override bool Registrar()
        {
            base.Registrar();
            Conexao.Query = $@"EXECUTE REGISTRA_PESSOA_JURIDICA {Id}, '{Cnpj}', '{Atividade}', '{Fantasia}'";
            SqlDataReader dr = Conexao.ExecReader();
            if (!dr.Read())
                throw new Exception("IMPOSSIVEL CADASTRAR PESSOA JURIDICA!");
            MessageBox.Show(Form1.container, "Cadastro de Pessoa Juridica Realizado com Êxito!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CodPessoaJuridica = Int32.Parse(dr[0].ToString());
            dr.Close();
            return true;
        }
        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = $"SELECT P.ID, P.ID, P.NOME, J.FANTASIA, J.CNPJ, J.ATIVIDADE, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM "+
                            $" FROM PESSOA P" +
                            $" FULL OUTER JOIN JURIDICA J" +
                            $" ON J.CODPESSOA = P.ID" +
                            $" INNER JOIN CIDADE C" +
                            $" ON C.ID = P.CODCIDADE WHERE P.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = $"SELECT P.ID, P.ID, P.NOME, J.FANTASIA, J.CNPJ, J.ATIVIDADE, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                            $" FROM PESSOA P" +
                            $" FULL OUTER JOIN JURIDICA J" +
                            $" ON J.CODPESSOA = P.ID" +
                            $" INNER JOIN CIDADE C" +
                            $" ON C.ID = P.CODCIDADE";
            return Conexao.ExecAdapter();
        }
        public static DataTable ListarBusca(String nome)
        {
            Conexao.Query = $"SELECT P.ID, P.NOME, J.FANTASIA, J.CNPJ, J.ATIVIDADE, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                           $" FROM PESSOA P" +
                           $" FULL OUTER JOIN JURIDICA J" +
                           $" ON J.CODPESSOA = P.ID" +
                           $" INNER JOIN CIDADE C" +
                           $" ON C.ID = P.CODCIDADE" +
                           $" WHERE P.NOME LIKE '%{nome}%'";
            return Conexao.ExecAdapter();
        }
        public static DataTable ListarBusca(String nome, bool ativo)
        {
            Conexao.Query = $"SELECT P.ID, P.NOME, J.FANTASIA, J.CNPJ, J.ATIVIDADE, C.NOME AS CIDADE, P.LOGRADOURO, P.NUM" +
                          $" FROM PESSOA P" +
                          $" FULL OUTER JOIN JURIDICA J" +
                          $" ON J.CODPESSOA = P.ID" +
                          $" INNER JOIN CIDADE C" +
                          $" ON C.ID = P.CODCIDADE" +
                          $" WHERE P.NOME LIKE '%{nome}%'" +
                          $" AND P.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
    }
}
