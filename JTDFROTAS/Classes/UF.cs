using System;

namespace JTDFROTAS.Classes
{
    class UF : ICRUD
    {
        private int id;
        private String nome;
        private String sigla;

        public String Nome
        {
            get { return nome.ToUpper(); }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new FormatException($"Valor atribuido ao campo *{nameof(nome)}* é inválido!");
                nome = value.ToUpper();
            }
        }
        public String Sigla
        {
            get { return sigla.ToUpper(); }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new FormatException($"Valor atribuido ao campo *{nameof(sigla)}* é inválido!");
                sigla = value.ToUpper();
            }
        }
        public UF(String nome, String sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public bool Registrar()
        {
            throw new NotImplementedException();
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
