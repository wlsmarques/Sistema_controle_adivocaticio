using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {

        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.ToTable("Pagamento");
        }

    }
}
