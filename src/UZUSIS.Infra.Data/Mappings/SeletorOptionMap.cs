using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class SeletorOptionOptionMap : EntityMap<SeletorOption>
{
    public void Configure(EntityTypeBuilder<SeletorOption> builder)
    {
        
        builder.Property(s => s.SeletorName)
            .HasColumnType("VARCHAR");

        builder.Property(s => s.Foto);
        
        builder.HasOne(s => s.Atributo);

    }
}