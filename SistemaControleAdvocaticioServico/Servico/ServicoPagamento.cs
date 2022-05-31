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
    public class ServicoParcela : IServicoParcela
    {

        private readonly IRepositorioParcela _repositorioParcela;

        public ServicoParcela(IRepositorioParcela repositorioParcela)
        {
            _repositorioParcela = repositorioParcela;
        }


        public void Adicionar(Parcela obj)
        {
            if (obj != null)
            {
                _repositorioParcela.Adicionar(obj);
            }
        }

        public void Atualizar(Parcela obj)
        {
            if(obj != null)
            {
                _repositorioParcela.Atualizar(obj);
            }
            
        }

        public void Deletar(Parcela obj)
        {
            if(obj != null)
            {
                _repositorioParcela.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parcela> Listar()
        {
            return _repositorioParcela.Listar();
        }

        public Parcela PesquisaPorCodigo(int codigo)
        {
            return _repositorioParcela.PesquisaPorCodigo(codigo);
        }

    }
}
