using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class FeedbackMap : EntityMap<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {

        builder.ToTable("Feedback");

        builder.HasOne(c => c.Cliente);
        builder.HasMany<Produto>(f => f.Produtos);
        
        
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Stars)
            .HasColumnType("VARCHAR(9)");

   
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);


    }
}