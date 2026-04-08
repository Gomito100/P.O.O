using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    abstract class Produto
    {
        protected int id;
        protected string nome;
        protected double preco;
        protected int stock;
        protected Categoria categoria;

        public Produto(int id, string nome, double preco, int stock, Categoria cat)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.stock = stock;
            this.categoria = cat;
            cat.AdicionarProduto(this);
        }

        public string GetNome() => nome;
        public double GetPreco() => preco;

        public bool TemStock() => stock > 0;

        public void ReduzirStock(int qtd)
        {
            if (qtd <= stock)
                stock -= qtd;
        }

        public abstract double CalcularFrete();

        public override string ToString()
        {
            return $"{nome} | {preco} Kz | Stock: {stock}";
        }
    }
}
