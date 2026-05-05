using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigAluguerVeiculos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string BI { get; set; }

        public Cliente(string nome, string bi)
        {
            Nome = nome;
            BI = bi;
        }
    }
}