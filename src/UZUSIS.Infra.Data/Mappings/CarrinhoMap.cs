using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class CarrinhoMap : EntityMap<Carrinho>
{
    public void Configure(EntityTypeBuilder<Carrinho> builder)
    {

        builder.ToTable("Carrinho");
        
        builder
            .HasMany(c => c.Produtos);

        builder
            .HasOne(c => c.Cliente)
            .WithOne(c => c.Carrinho);

    }
}