using System;
using System.Text.RegularExpressions;

namespace JTDFROTAS.Classes
{
    class Juridica : Pessoa
    {
        private String cnpj;
        private int codPessoa;

        public String Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                String valor = Regex.Replace(value, "[^0-9]", "");
                if (valor.Length != 14)
                    throw new ArgumentException("Valores não correspondem a um CNPJ Válido!");
                cnpj = value;
            }
        }

        public Juridica(String nome, String logradouro, String num, int codCidade, String cnpj, int codPessoa)
            : base(nome, logradouro, num, codCidade, new Telefone("",""))
        {
            codPessoa = Id;
            Cnpj = cnpj;
        }
        public override bool Registrar()
        {
            return true;
        }
    }
}
