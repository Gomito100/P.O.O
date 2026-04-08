using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    class ProdutoFisico : Produto
    {
        private double peso;

        public ProdutoFisico(int id, string nome, double preco, int stock, Categoria cat, double peso)
            : base(id, nome, preco, stock, cat)
        {
            this.peso = peso;
        }

        public override double CalcularFrete() => peso * 200;
    }
}
