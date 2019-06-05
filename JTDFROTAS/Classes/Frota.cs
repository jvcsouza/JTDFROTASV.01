using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    class Frota
    {
        private int _codVeiculo, _codMotorista, _codViagem;
        private String _placa;

        public int CodVeiculo { get => _codVeiculo; set => _codVeiculo = value; }
        public int CodMotorista { get => _codMotorista; set => _codMotorista = value; }
        public int CodViagem { get => _codViagem; set => _codViagem = value; }
        public string Placa { get => _placa; set => _placa = value; }

        public Frota(int codVeiculo, int codMotorista, int codViagem)
        {
            CodVeiculo = codVeiculo;
            CodMotorista = CodMotorista;
            CodViagem = codViagem;
        }
        public Frota(String placa, String nome, int codViagem)
        {
            CodVeiculo = Veiculo.Buscar(placa);
            CodMotorista = Motorista.Buscar(nome);
            CodViagem = codViagem;
        }

        public bool Registar()
        {
            Conexao.Query = $"INSERT INTO FROTA(CODVEICULO, CODMOTO, CODVIAGEM)" +
                            $"VALUES ({CodVeiculo}, (SELECT ID FROM MOTORISTA WHERE CODPESSOA = {CodMotorista}), {CodViagem});" +
                            $"SELECT SCOPE_IDENTITY() AS ID";
            SqlDataReader dr = Conexao.ExecReader();
            int id = 0;
            if (dr != null)
                if (dr.Read())
                    id = Int32.Parse(dr[0].ToString());
                else id = 0;
            if (!dr.IsClosed) dr.Close();
            return id == 0 ? false : true;
        }

    }
}
