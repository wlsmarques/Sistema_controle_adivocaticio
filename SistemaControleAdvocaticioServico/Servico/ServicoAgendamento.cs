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
    public class ServicoAgendamento : IServicoAgendamento
    {

        private readonly IRepositorioAgendamento _repositorioAgendamento;

        public ServicoAgendamento(IRepositorioAgendamento repositorioAgendamento)
        {
            _repositorioAgendamento = repositorioAgendamento;
        }


        public void Adicionar(Agendamento obj)
        {
            if (obj != null)
            {
                _repositorioAgendamento.Adicionar(obj);
            }
        }

        public void Atualizar(Agendamento obj)
        {
            if(obj != null)
            {
                _repositorioAgendamento.Atualizar(obj);
            }
            
        }

        public void Deletar(Agendamento obj)
        {
            if(obj != null)
            {
                _repositorioAgendamento.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Agendamento> Listar()
        {
            return _repositorioAgendamento.Listar();
        }

        public Agendamento PesquisaPorCodigo(int codigo)
        {
            return _repositorioAgendamento.PesquisaPorCodigo(codigo);
        }

    }
}
