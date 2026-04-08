using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    public class Manutencao
    {
        private static int contador = 1;
        private int id;
        private DateTime data;
        private string tipo;
        private string descricao;
        private double custo;
        private double km;

        public Manutencao(DateTime data, string tipo, string descricao, double custo, double km)
        {
            id = contador++;
            this.data = data;
            this.tipo = tipo;
            this.descricao = descricao;
            this.custo = custo;
            this.km = km;
        }

        public override string ToString() =>
            $"[Man.#{id}] {data:dd/MM/yyyy} | {tipo} | {descricao} | {custo:F2} Kz | {km:F0} km";
    }
}
