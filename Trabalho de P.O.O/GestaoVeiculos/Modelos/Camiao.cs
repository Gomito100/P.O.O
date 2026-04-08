using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Camiao : Veiculo
    {
        public Camiao(string m, string ma, string mo, int a, double km)
            : base(m, ma, mo, a, km) { }

        public override double CalcularValorDiaria() => 45000;
        public override string GetTipo() => "Camião";
    }
}
