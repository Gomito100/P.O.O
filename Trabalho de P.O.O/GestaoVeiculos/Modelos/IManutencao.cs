using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Modelos
{
    interface IManutencao
    {
        void Agendar(DateTime data);
        void RealizarManutencao();
        List<Manutencao> ObterHistorico();
    }
}
