using SigGestEscola.Modelos;

namespace GestaoEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== PROFESSOR =====
            Console.Write("Nome do professor: ");
            string nomeProf = Console.ReadLine();

            Console.Write("Data nascimento (yyyy-mm-dd): ");
            DateTime dataProf = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            string telProf = Console.ReadLine();

            Console.Write("Especialidade: ");
            string esp = Console.ReadLine();

            Professor prof = new Professor(nomeProf, dataProf, telProf, esp);

            // ===== TURMA =====
            Console.Write("Código da turma: ");
            string cod = Console.ReadLine();

            Console.Write("Capacidade: ");
            int cap = int.Parse(Console.ReadLine());

            Turma turma = new Turma(cod, cap, prof);

            // ===== ALUNOS =====
            Console.Write("Quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nAluno #{i + 1}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Data nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Telefone: ");
                string tel = Console.ReadLine();

                Console.Write("Número: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Curso: ");
                string curso = Console.ReadLine();

                Aluno a = new Aluno(nome, data, tel, num, curso);

                Console.Write("Quantas notas? ");
                int qtdNotas = int.Parse(Console.ReadLine());

                for (int j = 0; j < qtdNotas; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    a.AdicionarNota(double.Parse(Console.ReadLine()));
                }

                turma.AdicionarAluno(a);
            }

            // ===== RESULTADOS =====
            Console.WriteLine("\n--- PROFESSOR ---");
            Console.WriteLine(prof);

            prof.Leccionar();

            Console.WriteLine("\n--- TURMA ---");
            turma.Listar();

            Console.ReadKey();
        }
    }
}
