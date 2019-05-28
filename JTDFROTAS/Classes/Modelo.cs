using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class Modelo : ICRUD
    {
        private int id, codMarca;
        private String nome;
        private bool ativo;

        public Modelo()
        {

        }
        public Modelo(int id, int codMarca, String nome, bool ativo)
        {
            Id = id;
            CodMarca = codMarca;
            Nome = nome;
            Ativo = ativo;
        }

        public int Id { get => id; set => id = value; }
        public int CodMarca { get => codMarca; set => codMarca = value; }
        public string Nome { get => nome; set => nome = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT M.ID, MA.ID AS CODMARCA, MA.NOME AS MARCA, M.NOME AS MODELO, M.ATIVO
                            FROM MARCAVEICULO MA
                            INNER JOIN MODELOVEICULO M
                            ON MA.ID = M.CODMARCAVEICULO
                            WHERE M.ATIVO = " + (ativo ? '1' : '0')
                            + " ORDER BY MODELO";
            return Conexao.ExecAdapter();
        }

        public static DataTable Listar()
        {
            Conexao.Query = @"SELECT M.ID, MA.ID AS CODMARCA, MA.NOME AS MARCA, M.NOME AS MODELO, M.ATIVO
                            FROM MARCAVEICULO MA
                            INNER JOIN MODELOVEICULO M
                            ON MA.ID = M.CODMARCAVEICULO
                            ORDER BY MODELO";
            return Conexao.ExecAdapter();
        }

        public static Modelo Buscar(int id)
        {
            Modelo m;
            Conexao.Query = $"SELECT * FROM MODELOVEICULO"
                            + " WHERE ID = " + id
                            + " AND ATIVO = 1";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr.Read())
                m = new Modelo((int) dr["id"], (int) dr["codmarcaveiculo"], dr["nome"].ToString(), (bool) dr["ativo"]);
            else
                m = new Modelo(0, 0, "", false);
            dr.Close();
            return m;
        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        bool ICRUD.Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Registrar()
        {
            throw new NotImplementedException();
        }
    }
}
