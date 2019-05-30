using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    public class Fisica : Pessoa
    {
        private int id;
        private String cpf;
        private int codPessoa;
        private int codCidade;
        private String logradouro;
        private String num;
        private String nome;

        public Fisica(String nome, String logradouro, String num, int codCidade, String cpf, object fones)
            : base(nome, logradouro, num, codCidade, fones)
        {
            Cpf = cpf;
        }

        public Fisica(int id, String nome, String logradouro, String num, int codCidade, String cpf, int codPessoa)
            : base(id, nome, logradouro, num, codCidade)
        {
            codPessoa = id;
            Cpf = cpf;
        }

        public Fisica(int id, int codP, String nome, String logradouro, String num, int codCidade, String cpf, int codPessoa)
            : base(codP, nome, logradouro, num, codCidade)
        {
            IdFisica = id;
            codPessoa = codP;
            Cpf = cpf;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public int CodCidade { get => codCidade; set => codCidade = value; }
        public int IdFisica { get => id; set => id = value; }

        public override bool Registrar()
        {
            base.Registrar();
            codPessoa = Id;

            return true;
        }
    }
}
