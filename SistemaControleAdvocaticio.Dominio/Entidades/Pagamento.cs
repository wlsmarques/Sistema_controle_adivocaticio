using System;

namespace SistemaControleAdvocaticio.Dominio.Entidades
{
    public class Pagamento
    {

        public int Codigo { get; set; }

        public Cliente Cliente { get; set; }

        public Processo Processo { get; set; }

        public int QuantidadeParcelas { get; set; }

        public float Valor { get; set; }

        public DateTime DataVencimento { get; set; }
        
        public DateTime DataPagamento { get; set; }

    }
}
