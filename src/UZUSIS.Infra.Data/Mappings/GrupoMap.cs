using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class GrupoMap : EntityMap<Grupo>
{
    public void Configure(EntityTypeBuilder<Grupo> builder)
    {
        builder.ToTable("Grupo");

        builder.HasKey(g => g.Id);

        builder.Property(g => g.IdentificadorGrupo)
            .IsRequired()
            .HasColumnType("VARCHAR(100)");

        builder.HasMany<Produto>(p => p.Produtos);
        
        builder.HasIndex(g => g.IdentificadorGrupo)
            .IsUnique(true);
        
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);
    }
}