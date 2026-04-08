using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Motociclo : Veiculo
    {
        private int cilindrada;

        public Motociclo(string m, string ma, string mo, int a, double km, int cil)
            : base(m, ma, mo, a, km)
        {
            cilindrada = cil;
        }

        public override double CalcularValorDiaria() => 8000;
        public override string GetTipo() => "Motociclo";
    }
}
