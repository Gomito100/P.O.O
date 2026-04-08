using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaMunicipal.Modelos
{
    public class Emprestimo
    {
        private static int contadorId = 1;
        private int id;
        private DateTime dataEmprestimo;
        private DateTime dataDevolPrevista;
        private DateTime? dataDevolReal;
        private Membro membro;
        private Livros livro;

        public Emprestimo(Membro membro, Livros livro, int diasPrazo = 14)
        {
            this.id = contadorId++;
            this.membro = membro;
            this.livro = livro;
            this.dataEmprestimo = DateTime.Now;
            this.dataDevolPrevista = DateTime.Now.AddDays(diasPrazo);
            this.dataDevolReal = null;

            livro.MarcarEmprestado();
            membro.AdicionarEmprestimo(this);
        }

        public int CalcularAtraso()
        {
            DateTime referencia = dataDevolReal ?? DateTime.Now;
            int dias = (int)(referencia - dataDevolPrevista).TotalDays;
            return dias > 0 ? dias : 0;
        }

        public bool EstaAtrasado() => CalcularAtraso() > 0;
        public bool EstaConcluido() => dataDevolReal.HasValue;

        public void RegistarDevolucao()
        {
            dataDevolReal = DateTime.Now;
            livro.MarcarDevolvido();
            Console.WriteLine($"Devolução: '{livro.GetTitulo()}' por {membro.GetNome()}");
        }

        public double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * 50.0;
        }

        public override string ToString()
        {
            string estado = EstaConcluido()
                ? "Devolvido"
                : (EstaAtrasado() ? $"ATRASADO ({CalcularAtraso()} dias)" : "Activo");

            return $"[Emp #{id}] '{livro.GetTitulo()}' → {membro.GetNome()} | Estado: {estado}";
        }
    }
}
