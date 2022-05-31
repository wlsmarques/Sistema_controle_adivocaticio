using System;

namespace SistemaControleAdvocaticio.Dominio.Entidades
{
    public class Agendamento
    {

        public int Codigo { get; set; }

        public int ClienteCodigo { get; set; }

        public int ProcessoCodigo { get; set; }

        public int TipoAgendamentoCodigo { get; set; }

        public DateTime DataAgendamento { get; set; }

    }
}
