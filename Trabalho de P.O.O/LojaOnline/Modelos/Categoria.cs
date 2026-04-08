using System;
using System.Collections.Generic;
using System.Text;

namespace LojaOnline.Modelos
{
    class Categoria
    {
        private int id;
        private string nome;
        private List<Produto> produtos;

        public Categoria(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto p) => produtos.Add(p);
        public string GetNome() => nome;

        public override string ToString() =>
            $"Categoria {id} - {nome} ({produtos.Count} produtos)";
    }
}
