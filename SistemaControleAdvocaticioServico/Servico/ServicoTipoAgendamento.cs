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
    public class ServicoTipoAgendamento : IServicoTipoAgendamento
    {

        private readonly IRepositorioTipoAgendamento _repositorioTipoAgendamento;

        public ServicoTipoAgendamento(IRepositorioTipoAgendamento repositorioTipoAgendamento)
        {
            _repositorioTipoAgendamento = repositorioTipoAgendamento;
        }



        public void Adicionar(TipoAgendamento obj)
        {
            if (obj != null)
            {
                _repositorioTipoAgendamento.Adicionar(obj);
            }
        }

        public void Atualizar(TipoAgendamento obj)
        {
            if(obj != null)
            {
                _repositorioTipoAgendamento.Atualizar(obj);
            }
            
        }

        public void Deletar(TipoAgendamento obj)
        {
            if(obj != null)
            {
                _repositorioTipoAgendamento.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoAgendamento> Listar()
        {
            return _repositorioTipoAgendamento.Listar();
        }

        public TipoAgendamento PesquisaPorCodigo(int codigo)
        {
            return _repositorioTipoAgendamento.PesquisaPorCodigo(codigo);
        }
    }
}
