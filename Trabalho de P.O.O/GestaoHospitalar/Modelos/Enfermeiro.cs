using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Enfermeiro : Pessoa
    {
        private TipoTurno turno;

        public Enfermeiro(string nome, DateTime dataNascimento, string nif, string telefone, string email,
                          TipoTurno turno)
            : base(nome, dataNascimento, nif, telefone, email)
        {
            this.turno = turno;
        }
    }
}
