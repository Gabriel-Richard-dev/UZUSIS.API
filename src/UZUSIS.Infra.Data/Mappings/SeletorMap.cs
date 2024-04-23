using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class SeletorMap : EntityMap<Seletor>
{
    public void Configure(EntityTypeBuilder<Seletor> builder)
    {
        
        builder.Property(s => s.Title)
            .HasColumnType("VARCHAR");
        builder.HasMany(s => s.SeletorOptions);
        
    }
}