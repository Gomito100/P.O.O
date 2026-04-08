using System;
using System.Collections.Generic;
using System.Text;

namespace SigGestEscola.Modelos
{
    abstract class Pessoa
    {
        protected string nome;
        protected DateTime dataNascimento;
        protected string telefone;

        public Pessoa(string nome, DateTime dataNascimento, string telefone)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
        }

        public string GetNome() => nome;

        public int GetIdade()
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;
            return idade;
        }

        public override string ToString()
        {
            return $"{nome} | {telefone} | {GetIdade()} anos";
        }
    }
}