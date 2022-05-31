using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticioServico.Servico
{
    public class ServicoPagamento : IServicoPagamento
    {

        private readonly IRepositorioPagamento _repositorioPagamento;

        public ServicoPagamento(IRepositorioPagamento repositorioPagamento)
        {
            _repositorioPagamento = repositorioPagamento;
        }


        public void Adicionar(Pagamento obj)
        {
            if (obj != null)
            {
                _repositorioPagamento.Adicionar(obj);
            }
        }

        public void Atualizar(Pagamento obj)
        {
            if(obj != null)
            {
                _repositorioPagamento.Atualizar(obj);
            }
            
        }

        public void Deletar(Pagamento obj)
        {
            if(obj != null)
            {
                _repositorioPagamento.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagamento> Listar()
        {
            return _repositorioPagamento.Listar();
        }

        public Pagamento PesquisaPorCodigo(int codigo)
        {
            return _repositorioPagamento.PesquisaPorCodigo(codigo);
        }

    }
}
