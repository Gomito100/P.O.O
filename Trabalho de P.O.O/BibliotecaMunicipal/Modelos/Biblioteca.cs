using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaMunicipal.Modelos
{
    public class Biblioteca
    {
        private string nome;
        private List<Livros> acervo;
        private List<Membro> membros;
        private List<Emprestimo> emprestimos;

        public Biblioteca(string nome)
        {
            this.nome = nome;
            acervo = new List<Livros>();
            membros = new List<Membro>();
            emprestimos = new List<Emprestimo>();
        }

        public void AdicionarLivro(Livros livro) => acervo.Add(livro);
        public void RegistarMembro(Membro membro) => membros.Add(membro);

        public List<Livros> GetAcervo() => acervo;
        public List<Membro> GetMembros() => membros;

        public Emprestimo RealizarEmprestimo(Membro membro, Livros livro)
        {
            if (!livro.EstaDisponivel())
            {
                Console.WriteLine("[ERRO] Livro indisponível.");
                return null;
            }

            Emprestimo emp = new Emprestimo(membro, livro);
            emprestimos.Add(emp);
            Console.WriteLine("Empréstimo realizado!");
            return emp;
        }

        public void ListarAcervo()
        {
            Console.WriteLine("\n--- LIVROS ---");
            for (int i = 0; i < acervo.Count; i++)
                Console.WriteLine($"{i} - {acervo[i]}");
        }

        public void ListarMembros()
        {
            Console.WriteLine("\n--- MEMBROS ---");
            for (int i = 0; i < membros.Count; i++)
                Console.WriteLine($"{i} - {membros[i]}");
        }

        public void ListarEmprestimos()
        {
            Console.WriteLine("\n--- EMPRÉSTIMOS ---");
            foreach (var e in emprestimos)
                Console.WriteLine(e);
        }
    }
}
