using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class FavoritoMap : EntityMap<Favorito>
{
    public FavoritoMap(EntityTypeBuilder<Favorito> builder)
    {

        builder.ToTable("Favorito");

        builder.HasOne(c => c.Cliente);

        builder.HasMany<Produto>(c => c.Produtos);

   
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);


    }
    
    
}