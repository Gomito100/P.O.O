using System;
using System.Collections.Generic;
using System.Text;

namespace SigGestEscola.Modelos
{
    class Professor : Pessoa
    {
        private string especialidade;
        private List<Aluno> alunos;

        public Professor(string nome, DateTime dataNascimento, string telefone, string especialidade)
            : base(nome, dataNascimento, telefone)
        {
            this.especialidade = especialidade;
            alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno a) => alunos.Add(a);

        public void Leccionar()
        {
            Console.WriteLine($"{nome} está a leccionar {especialidade}");
        }

        public override string ToString()
        {
            return $"Professor: {nome} | {especialidade} | Alunos: {alunos.Count}";
        }
    }
}