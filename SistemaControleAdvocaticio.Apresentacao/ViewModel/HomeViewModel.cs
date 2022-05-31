using SistemaControleAdvocaticio.Apresentacao.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Apresentacao.ViewModel
{
    public class HomeViewModel
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1}", MinimumLength = 5)]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1}", MinimumLength = 8)]
        public string Senha { get; set; }


    }
}
