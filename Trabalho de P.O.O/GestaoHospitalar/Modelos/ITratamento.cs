using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoHospitalar.Modelos
{
    interface ITratamento
    {
        void IniciarTratamento();
        void ConcluirTratamento();
        void RegistarEvolucao(string observacao);
    }
}
