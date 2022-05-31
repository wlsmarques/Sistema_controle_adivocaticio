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
    public class ServicoCliente : IServicoCliente
    {

        private readonly IRepositorioCliente _repositorioCliente;

        public ServicoCliente(IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
        }


        public void Adicionar(Cliente obj)
        {
            if (obj != null)
            {
                _repositorioCliente.Adicionar(obj);
            }
        }

        public void Atualizar(Cliente obj)
        {
            if(obj != null)
            {
                _repositorioCliente.Atualizar(obj);
            }
            
        }

        public void Deletar(Cliente obj)
        {
            if(obj != null)
            {
                _repositorioCliente.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Listar()
        {
            return _repositorioCliente.Listar();
        }

        public Cliente PesquisaPorCodigo(int codigo)
        {
            return _repositorioCliente.PesquisaPorCodigo(codigo);
        }

        public Cliente PesquisarPorCpf(string cpf)
        {
            return _repositorioCliente.PesquisarPorCpf(cpf);
        }


    }
}
