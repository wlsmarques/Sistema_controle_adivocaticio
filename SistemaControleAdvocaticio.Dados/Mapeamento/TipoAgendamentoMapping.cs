using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class TipoAgendamentoMapping : IEntityTypeConfiguration<TipoAgendamento>
    {

        public void Configure(EntityTypeBuilder<TipoAgendamento> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.ToTable("TipoAgendamento");
        }

    }
}
