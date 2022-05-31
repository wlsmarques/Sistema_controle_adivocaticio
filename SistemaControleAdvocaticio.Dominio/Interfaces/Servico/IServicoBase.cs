using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dominio.Interfaces.Servico
{
    public interface IServicoBase<TEntity> where TEntity : class
    {

        void Adicionar(TEntity obj);

        TEntity PesquisaPorCodigo(int codigo);

        IEnumerable<TEntity> Listar();

        void Atualizar(TEntity obj);

        void Deletar(TEntity obj);

        void Dispose();

    }
}
