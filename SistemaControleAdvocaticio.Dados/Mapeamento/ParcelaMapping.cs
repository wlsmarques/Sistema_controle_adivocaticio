using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class ParcelaMapping : IEntityTypeConfiguration<Parcela>
    {

        public void Configure(EntityTypeBuilder<Parcela> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.ToTable("Parcela");
        }

    }
}
