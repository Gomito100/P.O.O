using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Cliente
    {
        private int id;
        private string nome;

        public Cliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public string GetNome() => nome;
    }
}
