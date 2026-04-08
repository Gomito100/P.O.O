using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    class ItemCarrinho
    {
        private Produto produto;
        private int quantidade;

        public ItemCarrinho(Produto p, int q)
        {
            produto = p;
            quantidade = q;
        }

        public double Subtotal() => produto.GetPreco() * quantidade;

        public override string ToString()
        {
            return $"{produto.GetNome()} x{quantidade} = {Subtotal()} Kz";
        }
    }

}
