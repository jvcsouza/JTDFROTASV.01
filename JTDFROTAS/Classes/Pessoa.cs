using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JTDFROTAS.Classes
{
    public class Pessoa : ICRUD
    {
        private String _nome, _logradouro, _num;
        private bool _ativo = true;
        private int _id, _codcidade;
        private List<Telefone> _contatos;

        public int Id { get { return _id; } set
            {
                _id = value;
            }
        }
        public String Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                _nome = value;
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

        public Pessoa(String nome, String logradouro, String num, int codcidade, object fones)
        {
            Nome = nome;
            Logradouro = logradouro;
            Num = num;
            _codcidade = codcidade;
            Contatos = (List<Telefone>)fones;
        }

        public Pessoa(String nome, String logradouro, String num, int codcidade)
        {
            _nome = nome;
            _logradouro = logradouro;
            _num = num;
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
            Conexao.Query = $@"EXECUTE REGISTRAPESSOA '{Nome}', {_codcidade}, '{Endereco[0]}', '{Endereco[1]}', {_ativo}";
            SqlDataReader dr = Conexao.ExecReader();
            if (!dr.Read()) throw new Exception("PROBLEMAS NA INCLUSÃO DE PESSOA!");
            _id = Int32.Parse(dr[0].ToString());
            dr.Close();
            if (Contatos != null)
                if (Contatos.Count > 0)
                    foreach (Telefone fone in Contatos)
                    {
                        fone.Registrar(_id);
                    }
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
