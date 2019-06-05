using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    class Viagem
    {
        private int _id, _cidadeDestino, _cidadeSaida, _codCliente, _codUsuario;
        private Double _custototal, _kmtotal;
        private String _dataEntrega;

        public int Id { get => _id; set => _id = value; }
        public int CidadeDestino { get => _cidadeDestino; set => _cidadeDestino = value; }
        public int CidadeSaida { get => _cidadeSaida; set => _cidadeSaida = value; }
        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public double Custototal { get => _custototal; set => _custototal = value; }
        public double Kmtotal { get => _kmtotal; set => _kmtotal = value; }
        public String DataEntrega { get => _dataEntrega; set => _dataEntrega = value; }

        public Viagem(int destino, int saida, int cliente, Double custo, Double kmtotal, String dataEntrega)
        {
            CidadeDestino = destino;
            CidadeSaida = saida;
            CodCliente = cliente;
            Custototal = custo;
            Kmtotal = kmtotal;
            DataEntrega = dataEntrega;
        }

        public bool Registrar()
        {
            Conexao.Query = $"INSERT INTO VIAGEM(CODCLIENTE, DESTINO, SAIDA, KMTOTAL, DATARESGISTRO, ULTIMAALTERA, CODUSUARIO, CUSTOTOTAL, DATAFINAL)  " +
                            $"VALUES ({CodCliente}, {CidadeDestino}, {CidadeDestino}, {Kmtotal}, GETDATE(), GETDATE(), {Usuario.Id}, (SELECT CAST({Custototal.ToString().Replace(',','.')} AS MONEY) AS M), '{DataEntrega}');" +
                            $"SELECT SCOPE_IDENTITY() AS ID";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr != null)
                if (dr.Read()) Id = Int32.Parse(dr[0].ToString());
                else Id = 0;
            if (!dr.IsClosed) dr.Close();
            return Id != 0 ? true : false;
        }

    }
}
