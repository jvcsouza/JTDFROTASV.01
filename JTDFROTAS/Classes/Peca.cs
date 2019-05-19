using System;

namespace JTDFROTAS.Classes
{
    class Peca : ICRUD
    {
        private String nome;
        private int estoque;
        private Double preco;

        public Double Preco
        {
            get
            {
                return Preco;
            }
            set
            {
                if (value < 0) return;
                preco = value;
            }
        }

        public Peca(String nome, int estoque, Double preco)
        {
            this.estoque = estoque;
            this.nome = nome;
            this.preco = preco;
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
