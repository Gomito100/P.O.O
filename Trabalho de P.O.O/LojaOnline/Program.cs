using LojaOnline.Modelos;

namespace LojaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            // ===== CATEGORIA =====
            Categoria cat = new Categoria(1, "Geral");

            Console.Write("Quantos produtos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n1-Físico 2-Digital");
                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Stock: ");
                int stock = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    Console.Write("Peso: ");
                    double peso = double.Parse(Console.ReadLine());

                    produtos.Add(new ProdutoFisico(i + 1, nome, preco, stock, cat, peso));
                }
                else
                {
                    produtos.Add(new ProdutoDigital(i + 1, nome, preco, stock, cat));
                }
            }

            Console.WriteLine("\n--- Produtos ---");
            for (int i = 0; i < produtos.Count; i++)
                Console.WriteLine($"{i} - {produtos[i]}");

            // ===== CLIENTE =====
            Console.Write("\nNome do cliente: ");
            Cliente cliente = new Cliente(Console.ReadLine());

            Console.Write("Quantos itens deseja comprar? ");
            int itens = int.Parse(Console.ReadLine());

            for (int i = 0; i < itens; i++)
            {
                Console.Write("Escolha o produto (índice): ");
                int idx = int.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                cliente.GetCarrinho().Adicionar(produtos[idx], qtd);
            }

            Console.WriteLine("\nCliente: " + cliente);
            cliente.GetCarrinho().Mostrar();

            Console.ReadKey();
        }
    }
}