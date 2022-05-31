using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class AgendamentoMapping : IEntityTypeConfiguration<Agendamento>
    {

        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.HasKey(p => p.Codigo);

            //builder.Property(c => c.Cliente.Codigo)
            //    .IsRequired()
            //    .HasColumnType("int");

            //builder.Property(c => c.Processo.Codigo)
            //    .IsRequired()
            //    .HasColumnType("int");

            //builder.Property(c => c.TipoAgendamento.Codigo)
            //    .IsRequired()
            //    .HasColumnType("int");

            //builder.Property(c => c.DataAgendamento)
            //    .IsRequired()
            //    .HasColumnType("datetime");

            builder.ToTable("Agendamento");
        }

    }
}
