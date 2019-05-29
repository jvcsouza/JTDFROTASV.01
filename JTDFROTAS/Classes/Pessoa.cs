using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    public class Pessoa : ICRUD
    {
        private String _nome, _logradouro, _num;
        private bool _ativo = true;
        private int _id, _codcidade;
        private List<Telefone> _contatos;

        public int Id { get; }
        public String Nome {
            get
            {
                return Nome.ToUpper();
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
                return new string[2] { Logradouro, Num };
            }
            set { }
        }
        
        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Num { get => _num; set => _num = value; }
        internal List<Telefone> Contatos { get => _contatos; set => _contatos = value; }

        public Pessoa(String nome, String logradouro, String num, int codcidade)
        {
            Nome = nome;
            Logradouro = logradouro;
            Num = num;
            _codcidade = codcidade;
        }

        public Pessoa(int id, String nome, String logradouro, String num, int codcidade)
        {
            Id = id;
            Nome = nome;
            Logradouro = logradouro;
            Num = num;
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
