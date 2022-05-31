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
    public class ServicoProcesso : IServicoProcesso
    {

        private readonly IRepositorioProcesso _repositorioProcesso;

        public ServicoProcesso(IRepositorioProcesso repositorioProcesso)
        {
            _repositorioProcesso = repositorioProcesso;
        }


        public void Adicionar(Processo obj)
        {
            if (obj != null)
            {
                _repositorioProcesso.Adicionar(obj);
            }
        }

        public void Atualizar(Processo obj)
        {
            if(obj != null)
            {
                _repositorioProcesso.Atualizar(obj);
            }
            
        }

        public void Deletar(Processo obj)
        {
            if(obj != null)
            {
                _repositorioProcesso.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Processo> Listar()
        {
            return _repositorioProcesso.Listar();
        }

        public Processo PesquisaPorCodigo(int codigo)
        {
            return _repositorioProcesso.PesquisaPorCodigo(codigo);
        }

    }
}
