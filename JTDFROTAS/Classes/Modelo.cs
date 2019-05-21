using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public Modelo(int id, int codMarca, String nome)
        {
            Id = id;
            CodMarca = codMarca;
            Nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public int CodMarca { get => codMarca; set => codMarca = value; }
        public string Nome { get => nome; set => nome = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT M.ID, MA.ID AS CODMARCA, MA.NOME AS MARCA, M.NOME AS MODELO
                            FROM MARCAVEICULO MA
                            INNER JOIN MODELOVEICULO M
                            ON MA.ID = M.CODMARCAVEICULO
                            WHERE M.ATIVO = " + (ativo ? '1' : '0')
                            + " ORDER BY MODELO";
            return Conexao.ExecAdapter();

        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int id)
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
