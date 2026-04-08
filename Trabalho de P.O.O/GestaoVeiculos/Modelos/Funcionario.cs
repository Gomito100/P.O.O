using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    class Funcionario
    {
        private string nome;

        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public override string ToString() => nome;
    }
}
