using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    class Fisica : Pessoa
    {
        private String cpf;
        private int codPessoa;

        public Fisica(String nome, String logradouro, String num, int codCidade, String cpf, int codPessoa)
            : base(nome, logradouro, num, codCidade)
        {
            codPessoa = Id;
            this.cpf = cpf;
        }
        public override bool Registrar()
        {
            return true;
        }
    }
}
