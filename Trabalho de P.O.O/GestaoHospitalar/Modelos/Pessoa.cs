using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    abstract class Pessoa
    {
        protected string nome;
        protected DateTime dataNascimento;
        protected string nif;
        protected string telefone;
        protected string email;

        public Pessoa(string nome, DateTime dataNascimento, string nif, string telefone, string email)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.nif = nif;
            this.telefone = telefone;
            this.email = email;
        }

        public string GetNome() => nome;

        public int GetIdade()
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;
            return idade;
        }
    }
}
