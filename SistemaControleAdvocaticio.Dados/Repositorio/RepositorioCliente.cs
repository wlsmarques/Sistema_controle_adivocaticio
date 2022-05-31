using Microsoft.EntityFrameworkCore;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dados.Repositorio
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente

    {
        public RepositorioCliente(ContextoMySql contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Cliente PesquisarPorCpf(string cpf)
        {
            Cliente cliente = new Cliente();
            cliente.Cpf = cpf;
            try
            {
                cliente = _contexto.Clientes.Where(c => c.Cpf == cpf).FirstOrDefault();
            }
            catch (Exception )
            {
                
                throw ;
            }
            
            
            
            return cliente;
        }
    }
}
