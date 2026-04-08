using GestaoVeiculos.Modelos;

namespace GestaoVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            Console.Write("Quantos veículos deseja registar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n1-Automóvel 2-Moto 3-Camião");
                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Matrícula: ");
                string m = Console.ReadLine();

                Console.Write("Marca: ");
                string ma = Console.ReadLine();

                Console.Write("Modelo: ");
                string mo = Console.ReadLine();

                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());

                Console.Write("KM: ");
                double km = double.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    Console.Write("Portas: ");
                    int p = int.Parse(Console.ReadLine());
                    veiculos.Add(new Automovel(m, ma, mo, ano, km, p));
                }
                else if (tipo == 2)
                {
                    Console.Write("Cilindrada: ");
                    int c = int.Parse(Console.ReadLine());
                    veiculos.Add(new Motociclo(m, ma, mo, ano, km, c));
                }
                else
                {
                    veiculos.Add(new Camiao(m, ma, mo, ano, km));
                }
            }

            Console.WriteLine("\n--- VEÍCULOS ---");
            for (int i = 0; i < veiculos.Count; i++)
                Console.WriteLine($"{i} - {veiculos[i]}");

            Console.Write("\nNome do cliente: ");
            string nome = Console.ReadLine();
            Cliente cli = new Cliente(1, nome);

            Console.Write("Escolha veículo: ");
            int idx = int.Parse(Console.ReadLine());

            Console.Write("Dias: ");
            int dias = int.Parse(Console.ReadLine());

            new Reserva(cli, veiculos[idx], dias);

            Console.ReadKey();
        }
    }
}
