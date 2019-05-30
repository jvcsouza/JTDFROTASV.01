using System;

namespace JTDFROTAS.Classes
{
    class Telefone : ICRUD
    {
        private String contato, fone;

        public Telefone(String fone, int codPessoa)
        {

        }
        public Telefone(String fone)
        {

        }
        public Telefone(String contato, String fone)
        {

        }
        public Telefone(String contato, String fone, int codPessoa)
        {
            
        }

        public string Contato { get => Contato; set => Contato = value; }
        public string Fone { get => fone; set => fone = value; }

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

        public bool Registrar(int codPessoa)
        {
            return true;
        }

        public bool Registrar()
        {
            throw new NotImplementedException();
        }
    }
}
