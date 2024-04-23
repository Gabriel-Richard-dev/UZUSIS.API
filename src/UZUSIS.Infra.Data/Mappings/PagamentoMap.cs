using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class PagamentoMap : EntityMap<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.ToTable("Pagamento");


        builder.Property(p => p.ValorTotal)
            .HasColumnType("DECIMAL");

        builder.Property(p => p.Expires)
            .HasColumnType("DATETIME");

        builder.Property(p => p.DataEmissao)
            .HasColumnType("DATETIME");
        
        builder
            .HasMany(p => p.Produtos);
      
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);

    }
}