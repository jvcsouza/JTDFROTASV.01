using System;

namespace JTDFROTAS.Classes
{
    class Motorista : Pessoa
    {
        private int _codTipoCarteira;
        private int _codPessoa;

        public Motorista(String nome, String logradouro, String num, int codCidade, int codTipoCarteira) 
            : base(nome, logradouro, num, codCidade)
        {
            _codTipoCarteira = codTipoCarteira;
            _codPessoa = Id;
        }
        private bool Registrar(Motorista m)
        {
            return true;
        }
    }
}
