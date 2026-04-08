using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Medicamento
    {
        private int id;
        private string nome;

        public Medicamento(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public string GetNome() => nome;
    }
}
