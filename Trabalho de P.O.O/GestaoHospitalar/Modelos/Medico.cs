using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Medico : Pessoa
    {
        private string especialidade;
        private string departamento;

        public Medico(string nome, DateTime dataNascimento, string nif, string telefone, string email,
                      string especialidade, string departamento)
            : base(nome, dataNascimento, nif, telefone, email)
        {
            this.especialidade = especialidade;
            this.departamento = departamento;
        }
    }
}
