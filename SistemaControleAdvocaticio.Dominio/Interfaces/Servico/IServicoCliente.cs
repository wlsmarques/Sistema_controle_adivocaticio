using SistemaControleAdvocaticio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dominio.Interfaces.Servico
{
    public interface IServicoCliente : IServicoBase<Cliente>
    {
        Cliente PesquisarPorCpf(string cpf);
    }
}
