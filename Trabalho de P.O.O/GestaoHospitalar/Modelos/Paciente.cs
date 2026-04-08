using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Paciente : Pessoa
    {
        private string numProcesso;
        private string grupoSanguineo;
        private List<string> alergias;

        public Paciente(string nome, DateTime dataNascimento, string nif, string telefone, string email,
                        string numProcesso, string grupoSanguineo)
            : base(nome, dataNascimento, nif, telefone, email)
        {
            this.numProcesso = numProcesso;
            this.grupoSanguineo = grupoSanguineo;
            this.alergias = new List<string>();
        }

        public void AdicionarAlergia(string alergia) => alergias.Add(alergia);
    }
}
