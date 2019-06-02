using System;
using System.Data.SqlClient;

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
            Conexao.Query = $"INSERT INTO VEICULO (CODCLIENTE, PLACA, TIPOVEICULO, DATAREGISTRO, CUSTOMEDIOPKM)" +
                            $" VALUES ({codCliente}, '{placa.ToUpper()}', (SELECT ID FROM TIPOVEICULO WHERE NOME LIKE '{tipoVeiculo.ToUpper()}'), GETDATE(), {custoMedio}); " +
                            $"SELECT SCOPE_IDENTITY() AS ID";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr.Read()) id = Int32.Parse(dr[0].ToString());
            else throw new Exception();
            dr.Close();
            return true;
        }
    }
}
