using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    class Pessoa : ICRUD
    {
        private String _nome, _logradouro, _num;
        private bool _ativo = true;
        private int _id, _codcidade;

        public int Id { get; }
        public String Nome {
            get
            {
                return _nome;
            }
            set
            {
                Console.WriteLine("Registro não pode ser alterado diretamente!");
            }
        }
        public String[] Endereco
        {
            get
            {
                return new string[2] { _logradouro, _num };
            }
            set { }
        }

        public Pessoa(String nome, String logradouro, String num, int codcidade)
        {
            _nome = nome;
            _logradouro = logradouro;
            _num = num;
            _codcidade = codcidade;
        }
        
        public virtual bool Registrar()
        {
            //Registrar no banco
            //seta o id
            return true;
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
