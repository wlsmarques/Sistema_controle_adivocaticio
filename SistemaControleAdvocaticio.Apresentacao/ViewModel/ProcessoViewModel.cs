using SistemaControleAdvocaticio.Dominio.Entidades;
using System.Collections.Generic;

namespace SistemaControleAdvocaticio.Apresentacao.ViewModel
{
    public class ProcessoViewModel
    {
        public int Codigo { get; set; }
        public int clientecodigo { get; set; }

        public Cliente Cliente { get; set; }

        public List<Processo> ListaProcesso { get; set; }

        

    }
}
