using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaMunicipal.Modelos
{
    public class Livros
    {
        private string isbn;
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private bool disponivel;

        public Livros(string isbn, string titulo, string autor, int anoPublicacao)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.disponivel = true;
        }

        public bool EstaDisponivel() => disponivel;

        public void MarcarEmprestado()
        {
            if (!disponivel)
            {
                Console.WriteLine($"[AVISO] '{titulo}' já está emprestado.");
                return;
            }
            disponivel = false;
        }

        public void MarcarDevolvido() => disponivel = true;

        public string GetIsbn() => isbn;
        public string GetTitulo() => titulo;

        public override string ToString()
        {
            return $"[Livro] '{titulo}' - {autor} ({anoPublicacao}) | ISBN: {isbn} | Disponível: {(disponivel ? "Sim" : "Não")}";
        }
    }
}
