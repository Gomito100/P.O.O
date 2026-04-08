using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaMunicipal.Modelos
{
    public class Membro
    {
        private int idMembro;
        private string nome;
        private string email;
        private DateTime dataRegisto;
        private List<Emprestimo> emprestimos;

        public Membro(int idMembro, string nome, string email)
        {
            this.idMembro = idMembro;
            this.nome = nome;
            this.email = email;
            this.dataRegisto = DateTime.Now;
            this.emprestimos = new List<Emprestimo>();
        }

        public void AdicionarEmprestimo(Emprestimo emp) => emprestimos.Add(emp);

        public List<Emprestimo> GetEmprestimosActivos()
        {
            List<Emprestimo> activos = new List<Emprestimo>();
            foreach (Emprestimo e in emprestimos)
                if (!e.EstaConcluido()) activos.Add(e);
            return activos;
        }

        public bool TemMulta()
        {
            foreach (Emprestimo e in emprestimos)
                if (e.EstaAtrasado()) return true;
            return false;
        }

        public double CalcularMulta()
        {
            double total = 0;
            foreach (Emprestimo e in emprestimos)
                total += e.CalcularMulta(e.CalcularAtraso());
            return total;
        }

        public int GetId() => idMembro;
        public string GetNome() => nome;

        public override string ToString()
        {
            return $"[Membro #{idMembro}] {nome} | Email: {email}";
        }
    }
}
