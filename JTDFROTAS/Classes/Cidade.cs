using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    public class Cidade : ICRUD
    {
        private String _nome;
        private int _codUf, _id;
        private bool _ativo;

        public Cidade(int id, String nome, int codUf, bool ativo)
        {
            Id = id;
            Nome = nome;
            CodUf = codUf;
            Ativo = ativo;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int CodUf { get => _codUf; set => _codUf = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

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

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT c.ID, u.ID as CODESTADO, c.NOME, u.NOME AS ESTADO, u.UF, c.ATIVO
                            FROM UF u
                            INNER JOIN CIDADE c
                            ON u.ID = c.CODUF
                            WHERE c.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = @"SELECT c.ID, u.ID as CODESTADO, c.NOME, u.NOME AS ESTADO, u.UF, c.ATIVO
                            FROM UF u
                            INNER JOIN CIDADE c
                            ON u.ID = c.CODUF";
            return Conexao.ExecAdapter();
        }
        public bool Registrar()
        {
            return true;
        }
    }
}
