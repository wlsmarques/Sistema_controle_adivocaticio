using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaControleAdvocaticio.Dominio.Entidades;

namespace SistemaControleAdvocaticio.Dados.Mapeamento
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Codigo);

            builder.Property(c => c.Login)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.ToTable("Usuario");
        }

    }
}
