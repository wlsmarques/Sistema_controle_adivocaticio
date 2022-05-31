using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class ProcessoMapping : IEntityTypeConfiguration<Processo>
    {

        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.ToTable("Processo");
        }

    }
}
