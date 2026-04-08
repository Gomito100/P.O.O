using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Reserva
    {
        public Reserva(Cliente c, Veiculo v, int dias)
        {
            double total = dias * v.CalcularValorDiaria();
            Console.WriteLine($"Reserva: {c.GetNome()} → {v.GetMatricula()} | {total} Kz");
        }
    }
}
