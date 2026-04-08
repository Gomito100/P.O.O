using BibliotecaMunicipal.Modelos;


namespace BibliotecaMunicipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca bib = new Biblioteca("Biblioteca Municipal");

            // ===== LIVROS =====
            Console.Write("Quantos livros deseja registar? ");
            int qtdLivros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdLivros; i++)
            {
                Console.WriteLine($"\nLivro #{i + 1}");

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Ano: ");
               int ano = int.Parse(Console.ReadLine());

                bib.AdicionarLivro(new Livros(isbn, titulo, autor, ano));
            }

            // ===== MEMBROS =====
            Console.Write("\nQuantos membros? ");
            int qtdMembros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdMembros; i++)
            {
                Console.WriteLine($"\nMembro #{i + 1}");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                bib.RegistarMembro(new Membro(id, nome, email));
            }

            // ===== EMPRÉSTIMOS =====
            Console.Write("\nQuantos empréstimos? ");
            int qtdEmp = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdEmp; i++)
            {
                Console.WriteLine($"\nEmpréstimo #{i + 1}");

                bib.ListarMembros();
                Console.Write("Escolha o índice do membro: ");
                int idxM = int.Parse(Console.ReadLine());

                bib.ListarAcervo();
                Console.Write("Escolha o índice do livro: ");
                int idxL = int.Parse(Console.ReadLine());

                bib.RealizarEmprestimo(
                    bib.GetMembros()[idxM],
                    bib.GetAcervo()[idxL]
                );
            }

            // ===== RESULTADOS =====
            bib.ListarEmprestimos();

            Console.WriteLine("\nFim do programa.");
            Console.ReadKey();
        }
    }
}