using Microsoft.EntityFrameworkCore;
using SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dados.Repositorio
{
    
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected ContextoMySql _contexto;
            
        public RepositorioBase(ContextoMySql contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(TEntity obj)
        {
            _contexto.Set<TEntity>().Add(obj);
            _contexto.SaveChanges();

        }

        public void Atualizar(TEntity obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;

            _contexto.SaveChanges(); 
            
        }

        public void Deletar(TEntity obj)
        {
            _contexto.Set<TEntity>().Remove(obj);
            _contexto.SaveChanges();
            
        }

        public IEnumerable<TEntity> Listar()
        {
            return _contexto.Set<TEntity>().ToList();
            
        }

        public TEntity PesquisaPorCodigo(int codigo)
        {
            return _contexto.Set<TEntity>().Find(codigo);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

    }
}
