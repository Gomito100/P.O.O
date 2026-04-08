using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    public class Seguro
    {
        private string apolice;
        private DateTime dataInicio;
        private DateTime dataFim;
        private double valorCobertura;

        public Seguro(string apolice, DateTime dataInicio, DateTime dataFim, double valorCobertura)
        {
            this.apolice = apolice;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.valorCobertura = valorCobertura;
        }

        public bool EstaActivo() => DateTime.Now >= dataInicio && DateTime.Now <= dataFim;

        public override string ToString()
        {
            return $"Apólice: {apolice} | {dataInicio:dd/MM/yyyy} → {dataFim:dd/MM/yyyy} | {(EstaActivo() ? "Activo" : "Inactivo")}";
        }
    }
}
