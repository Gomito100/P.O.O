using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Consulta
    {
        private Medico medico;
        private Paciente paciente;
        private List<Prescricao> prescricoes;

        public Consulta(Medico medico, Paciente paciente)
        {
            this.medico = medico;
            this.paciente = paciente;
            this.prescricoes = new List<Prescricao>();
        }

        public void AdicionarPrescricao(Prescricao p)
        {
            prescricoes.Add(p);
        }
    }
}
