using System.Collections.Generic;

namespace SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {

        void Adicionar(TEntity obj);

        TEntity PesquisaPorCodigo(int codigo);

        IEnumerable<TEntity> Listar();

        void Atualizar(TEntity obj);

        void Deletar(TEntity obj);

        void Dispose();

    }
}
