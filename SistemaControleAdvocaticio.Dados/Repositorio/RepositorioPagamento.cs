using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dados.Repositorio
{
    public class RepositorioPagamento : RepositorioBase<Pagamento>, IRepositorioPagamento

    {
        public RepositorioPagamento(ContextoMySql contexto) : base(contexto)
        {
        }
    }
}
