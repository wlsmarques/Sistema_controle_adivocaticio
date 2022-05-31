using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.ToTable("Cliente");
        }

    }
}
