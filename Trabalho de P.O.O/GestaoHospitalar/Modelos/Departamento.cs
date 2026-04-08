using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    class Departamento
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Enfermeiro> enfermeiros = new List<Enfermeiro>();

        public void AdicionarMedico(Medico m) => medicos.Add(m);
        public void AdicionarEnfermeiro(Enfermeiro e) => enfermeiros.Add(e);
    }
}
