using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class CarrinhoProdutoMap : EntityMap<CarrinhoProduto>
{
    public CarrinhoProdutoMap(EntityTypeBuilder<CarrinhoProduto> builder)
    {
        builder.ToTable("CarrinhoProduto");

        builder.HasKey(c => c.Id);

        builder.HasOne(c => c.Carrinho);

        builder.HasOne(c => c.Produto);


        builder.Property(c => c.Carrinho.Id);
        builder.Property(c => c.Produto.Id);
        
        
        builder.Property(c => c.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(c => c.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);

        
    }
}