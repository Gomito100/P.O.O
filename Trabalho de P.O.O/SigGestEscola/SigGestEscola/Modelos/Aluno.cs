using System;
using System.Collections.Generic;
using System.Text;

namespace SigGestEscola.Modelos
{
    class Aluno : Pessoa
    {
        private int numero;
        private string curso;
        private List<double> notas;

        public Aluno(string nome, DateTime dataNascimento, string telefone, int numero, string curso)
            : base(nome, dataNascimento, telefone)
        {
            this.numero = numero;
            this.curso = curso;
            notas = new List<double>();
        }

        public void AdicionarNota(double nota)
        {
            if (nota >= 0 && nota <= 20)
                notas.Add(nota);
        }

        public double CalcularMedia()
        {
            if (notas.Count == 0) return 0;
            double soma = 0;
            foreach (var n in notas) soma += n;
            return soma / notas.Count;
        }

        public string Situacao()
        {
            double m = CalcularMedia();
            if (m >= 10) return "Aprovado";
            if (m >= 8) return "Recurso";
            return "Reprovado";
        }

        public override string ToString()
        {
            return $"Aluno #{numero} | {nome} | Média: {CalcularMedia():F1} | {Situacao()}";
        }
    }
}
