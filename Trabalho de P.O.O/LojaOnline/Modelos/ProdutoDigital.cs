using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
        class ProdutoDigital : Produto
    {
        public ProdutoDigital(int id, string nome, double preco, int stock, Categoria cat)
            : base(id, nome, preco, stock, cat) { }

        public override double CalcularFrete() => 0;
    }
}
