using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Internamento : ITratamento
    {
        private Paciente paciente;
        private List<string> evolucoes;

        public Internamento(Paciente paciente)
        {
            this.paciente = paciente;
            this.evolucoes = new List<string>();
        }

        public void IniciarTratamento()
        {
            Console.WriteLine("Tratamento iniciado");
        }

        public void ConcluirTratamento()
        {
            Console.WriteLine("Tratamento concluído");
        }

        public void RegistarEvolucao(string obs)
        {
            evolucoes.Add(obs);
        }
    }
}
