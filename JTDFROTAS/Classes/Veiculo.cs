using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JTDFROTAS.Classes
{
    class Veiculo
    {
        private int id, codCliente, codModelo;
        private String tipoVeiculo, placa;
        private bool disponivel;
        private DateTime dataRegistro, ultimaAltera;
        private double custoMedio;

        public Veiculo(String placa, String tipoVeiculo, int codModelo, int codCliente, double custoMedio)
        {
            this.placa = placa;
            this.tipoVeiculo = tipoVeiculo;
            this.codModelo = codModelo;
            this.codCliente = codCliente;
            this.custoMedio = custoMedio;
        }
        public bool Registrar()
        {
            Conexao.Query = $"INSERT INTO VEICULO (CODMODELOVEICULO, CODCLIENTE, PLACA, TIPOVEICULO, DATARESGISTRO, CUSTOMEDIOPKM, ULTIMAALTERA)" +
                            $" VALUES ({codModelo}, {codCliente}, '{placa.ToUpper().Replace("-", "")}', (SELECT ID FROM TIPOVEICULO WHERE NOME LIKE '{tipoVeiculo.ToUpper()}'), GETDATE(), (SELECT CAST({custoMedio.ToString().Replace(",", ".")} AS MONEY) ), GETDATE()); " +
                            $"SELECT SCOPE_IDENTITY() AS ID";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr.Read())
            {
                id = Int32.Parse(dr[0].ToString());
                MessageBox.Show(Form1.container, "Cadastro de Veiculo Realizado com Êxito!.".ToUpper(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else throw new Exception();
            dr.Close();
            return true;
        }
        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = $"SELECT TOP (10) V.ID " +
                            $",P.NOME AS CLIENTE" +
                            $",PLACA" +
                            $",M.NOME AS MODELO" +
                            $",ULTIMAALTERA AS 'ULTIMA ALTERAÇÃO' " +
                            $",CUSTOMEDIOPKM AS 'CUSTO MÉDIO' " +
                            $"FROM[JTDFROTAS].[dbo].[VEICULO] V " +
                            $"INNER JOIN MODELOVEICULO M " +
                            $"ON M.ID = V.CODMODELOVEICULO " +
                            $"INNER JOIN PESSOA P " +
                            $"ON P.ID = V.CODCLIENTE " +
                            $"WHERE DISPONIVEL = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = $"SELECT TOP (10) V.ID " +
                            $",P.NOME AS CLIENTE" +
                            $",PLACA" +
                            $",M.NOME AS MODELO" +
                            $",ULTIMAALTERA AS 'ULTIMA ALTERAÇÃO' " +
                            $",CUSTOMEDIOPKM AS 'CUSTO MÉDIO' " +
                            $"FROM[JTDFROTAS].[dbo].[VEICULO] V " +
                            $"INNER JOIN MODELOVEICULO M " +
                            $"ON M.ID = V.CODMODELOVEICULO " +
                            $"INNER JOIN PESSOA P " +
                            $"ON P.ID = V.CODCLIENTE";
            return Conexao.ExecAdapter();
        }
        public static String Buscar(int idVeiculo)
        {
            Conexao.Query = $"SELECT V.PLACA, M.NOME " +
                            $"FROM VEICULO V " +
                            $"INNER JOIN MODELOVEICULO M " +
                            $"ON V.CODMODELOVEICULO = M.ID " +
                            $"WHERE V.ID = {idVeiculo} AND DISPONIVEL = 1";
            SqlDataReader dr = Conexao.ExecReader();
            String nome;
            if (!dr.Read())
                nome = "";
            else nome = dr[0].ToString();
            dr.Close();
            return nome;
        }

        public static int Buscar(String placa)
        {
            Conexao.Query = $"SELECT V.ID " +
                            $"FROM VEICULO V " +
                            $"WHERE V.PLACA LIKE '{placa}' AND DISPONIVEL = 1";
            SqlDataReader dr = Conexao.ExecReader();
            int id = 0;
            if (dr != null)
                if (!dr.Read()) id = 0;
                else id = Int32.Parse(dr[0].ToString());
            if(!dr.IsClosed) dr.Close();
            return id;
        }

        public static String consultaCustoMedio(String placa)
        {
            String custo = "";
            Conexao.Query = $"SELECT CUSTOMEDIOPKM FROM VEICULO WHERE PLACA LIKE '{placa}'";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr != null)
                if (dr.Read())
                    custo = dr[0].ToString();
            if (!dr.IsClosed) dr.Close();
            return custo;
        }
    }
}
