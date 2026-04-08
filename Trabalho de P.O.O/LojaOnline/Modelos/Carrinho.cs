using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    class Carrinho
    {
        private List<ItemCarrinho> itens = new List<ItemCarrinho>();

        public void Adicionar(Produto p, int qtd)
        {
            if (p.TemStock())
            {
                itens.Add(new ItemCarrinho(p, qtd));
                p.ReduzirStock(qtd);
            }
        }

        public void Mostrar()
        {
            double total = 0;
            Console.WriteLine("\n--- Carrinho ---");
            foreach (var i in itens)
            {
                Console.WriteLine(i);
                total += i.Subtotal();
            }
            Console.WriteLine($"TOTAL: {total} Kz");
        }
    }
}
