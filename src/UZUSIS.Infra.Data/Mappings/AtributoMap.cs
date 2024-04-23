using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class AtributoMap : EntityMap<Atributo>
{
    public void Configure(EntityTypeBuilder<Atributo> builder)
    {
        builder.ToTable("Atributo");
        
        builder.HasKey(c => c.Id);

        
        builder.Property(a => a.Title)
            .HasColumnType("VARCHAR");

        builder.HasMany(a => a.AtributoOptions);
        
        
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);
        
    }
}