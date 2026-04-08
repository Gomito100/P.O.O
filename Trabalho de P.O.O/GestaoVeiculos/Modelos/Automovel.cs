using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Automovel : Veiculo
    {
        private int portas;

        public Automovel(string m, string ma, string mo, int a, double km, int portas)
            : base(m, ma, mo, a, km)
        {
            this.portas = portas;
        }

        public override double CalcularValorDiaria() => 15000;
        public override string GetTipo() => "Automóvel";
    }
}
