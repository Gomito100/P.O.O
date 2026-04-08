using GestaoHospitalar.Modelos;

namespace GestaoHospitalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Hospitalar iniciado...");

            Paciente p = new Paciente("João", new DateTime(1990, 1, 1), "001", "900000000", "a@a.com", "P1", "A+");
            Medico m = new Medico("Dr. Silva", new DateTime(1980, 1, 1), "002", "911111111", "b@b.com", "Cardio", "Medicina");

            Consulta c = new Consulta(m, p);

            Console.WriteLine("Sistema funcionando!");
            Console.ReadKey();
        }
    }
}
