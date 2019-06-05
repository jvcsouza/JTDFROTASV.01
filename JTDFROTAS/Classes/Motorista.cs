using System;
using System.Data;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class Motorista : Pessoa
    {
        private int _codTipoCarteira;
        private int _codPessoa;

        public Motorista(String nome, String logradouro, String num, int codCidade, int codTipoCarteira)
            : base(nome, logradouro, num, codCidade, new Telefone("", ""))
        {
            _codTipoCarteira = codTipoCarteira;
            _codPessoa = Id;
        }
        private bool Registrar(Motorista m)
        {
            return true;
        }
        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = $"SELECT P.ID, P.NOME, C.TIPO AS CARTA FROM MOTORISTA M INNER JOIN PESSOA P ON P.ID = M.CODPESSOA INNER JOIN TIPOCARTA C ON C.ID = M.CODTIPOCARTA AND P.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = $"SELECT P.ID, P.NOME, C.TIPO AS CARTA FROM MOTORISTA M INNER JOIN PESSOA P ON P.ID = M.CODPESSOA INNER JOIN TIPOCARTA C ON C.ID = M.CODTIPOCARTA";
            return Conexao.ExecAdapter();
        }
        public static int Buscar(String nome)
        {
            Conexao.Query = $"SELECT ID FROM PESSOA WHERE NOME LIKE '{nome}'";
            SqlDataReader dr = Conexao.ExecReader();
            int id = 0;
            if (dr != null)
                if (dr.Read())
                    id = Int32.Parse(dr[0].ToString());
                else id = 0;
            if (!dr.IsClosed) dr.Close();
            return id;
        }
    }
}
