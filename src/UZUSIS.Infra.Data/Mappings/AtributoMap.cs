using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class AtributoMap : EntityMap<Atributo>
{
    public AtributoMap(EntityTypeBuilder<Atributo> builder)
    {
        builder.Property(a => a.Title)
            .HasColumnType("VARCHAR");
        
    }
}