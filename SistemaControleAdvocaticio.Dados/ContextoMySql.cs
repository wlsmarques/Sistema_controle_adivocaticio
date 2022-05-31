using Microsoft.EntityFrameworkCore;
using SistemaControleAdvocaticio.Dominio.Entidades;
//using System.Data.Entity.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Dados
{
    public class ContextoMySql : DbContext
    {
        
        public ContextoMySql(DbContextOptions<ContextoMySql> options) :base(options)
        {
            
        }

        

        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<Agendamento> Agendamentos { get; set; }

        public DbSet<TipoAgendamento> TipoAgendamentos { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Parcela> Parcelas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextoMySql).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

    }
}
