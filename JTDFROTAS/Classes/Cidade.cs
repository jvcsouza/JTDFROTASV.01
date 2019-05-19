using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    class Cidade : ICRUD
    {
        private String _nome;
        private int _codUf;

        public Cidade(String nome, int codUf)
        {
            Nome = nome;
            CodUf = codUf;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int CodUf { get => _codUf; set => _codUf = value; }

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

        public DataTable Listar()
        {
            throw new NotImplementedException();
        }

        public bool Registrar()
        {
            return true;
        }
    }
}
