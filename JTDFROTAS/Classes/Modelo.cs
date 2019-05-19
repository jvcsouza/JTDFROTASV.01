using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace JTDFROTAS.Classes
{
    class Modelo : ICRUD
    {
        public Modelo()
        {

        }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT M.ID, MA.NOME AS MARCA, M.NOME AS MODELO
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
