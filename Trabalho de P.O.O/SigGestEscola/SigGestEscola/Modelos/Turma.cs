using System;
using System.Collections.Generic;
using System.Text;

namespace SigGestEscola.Modelos
{
    class Turma
    {
        private string codigo;
        private int capacidade;
        private Professor professor;
        private List<Aluno> alunos;

        public Turma(string codigo, int capacidade, Professor professor)
        {
            this.codigo = codigo;
            this.capacidade = capacidade;
            this.professor = professor;
            alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno a)
        {
            if (alunos.Count < capacidade)
            {
                alunos.Add(a);
                professor.AdicionarAluno(a);
            }
            else
                Console.WriteLine("Turma cheia!");
        }

        public void Listar()
        {
            Console.WriteLine($"\nTurma {codigo}");
            foreach (var a in alunos)
                Console.WriteLine(a);
        }
    }
}
