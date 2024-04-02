using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class CarrinhoMap : EntityMap<Carrinho>
{
    public void Configure(EntityTypeBuilder<Carrinho> builder)
    {

        builder.ToTable("Carrinho");

        builder.HasKey(c => c.Id);
        
        builder
            .HasMany(c => c.Produtos);

        builder
            .HasOne(c => c.Cliente);
        
        builder.Property(c => c.Cliente.Id)
            .HasColumnType("BIGINT");

        builder.Property(c => c.valorTotal)
            .HasColumnType("DECIMAL(10,2)");
        
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);


    }
}