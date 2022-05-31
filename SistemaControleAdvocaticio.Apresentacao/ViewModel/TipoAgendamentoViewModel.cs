using SistemaControleAdvocaticio.Dominio.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaControleAdvocaticio.Apresentacao.ViewModel
{
    public class TipoAgendamentoViewModel
    {

        public int Codigo { get; set; }

        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "O campo {0} deve ter entre {2} e {1}", MinimumLength = 1)]
        public string Descricao { get; set; }

        public List<TipoAgendamento> ListaTipoAgendamento { get; set; }

    }
}
