using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    abstract class Veiculo : IManutencao
    {
        protected string matricula, marca, modelo;
        protected int ano;
        protected double km;
        protected EstadoVeiculo estado;
        protected List<Manutencao> historico;
        protected Seguro seguro;

        public Veiculo(string matricula, string marca, string modelo, int ano, double km)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.km = km;
            estado = EstadoVeiculo.DISPONIVEL;
            historico = new List<Manutencao>();
        }

        public abstract double CalcularValorDiaria();
        public abstract string GetTipo();

        public string GetMatricula() => matricula;
        public EstadoVeiculo GetEstado() => estado;

        public void AssociarSeguro(Seguro s) => seguro = s;

        public void Agendar(DateTime data)
        {
            estado = EstadoVeiculo.MANUTENCAO;
            Console.WriteLine($"Manutenção agendada para {data:dd/MM/yyyy}");
        }

        public void RealizarManutencao()
        {
            historico.Add(new Manutencao(DateTime.Now, "Revisão", "Preventiva", 25000, km));
            estado = EstadoVeiculo.DISPONIVEL;
        }

        public List<Manutencao> ObterHistorico() => historico;

        public override string ToString()
        {
            return $"[{GetTipo()}] {matricula} | {marca} {modelo} | {estado}";
        }
    }
}