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
    public class ServicoUsuario : IServicoUsuario
    {

        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }



        public void Adicionar(Usuario obj)
        {
            if (!string.IsNullOrEmpty(obj.Email) && !string.IsNullOrEmpty(obj.Senha))
            {
                _repositorioUsuario.Adicionar(obj);
            }
        }

        public void Atualizar(Usuario obj)
        {
            if(obj != null)
            {
                _repositorioUsuario.Atualizar(obj);
            }
            
        }

        public void Deletar(Usuario obj)
        {
            if(obj != null)
            {
                _repositorioUsuario.Deletar(obj);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Listar()
        {
            return _repositorioUsuario.Listar();
        }

        public Usuario PesquisaPorCodigo(int codigo)
        {
            return _repositorioUsuario.PesquisaPorCodigo(codigo);
        }
    }
}
