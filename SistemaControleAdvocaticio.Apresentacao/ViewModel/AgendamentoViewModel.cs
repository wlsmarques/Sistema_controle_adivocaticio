using SistemaControleAdvocaticio.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace SistemaControleAdvocaticio.Apresentacao.ViewModel
{
    public class AgendamentoViewModel
    {
        public int Codigo { get; set; }

        public int ClienteCodigo { get; set; }

        public int ProcessoCodigo { get; set; }

        public int TipoAgendamentoCodigo { get; set; }

        public DateTime DataAgendamento { get; set; }

        public List<Agendamento> ListaAgendamento { get; set; }

        

    }
}
