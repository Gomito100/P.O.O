using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    class Cliente
    {
        private string nome;
        private Carrinho carrinho;

        public Cliente(string nome)
        {
            this.nome = nome;
            carrinho = new Carrinho();
        }

        public Carrinho GetCarrinho() => carrinho;

        public override string ToString() => nome;
    }
}
