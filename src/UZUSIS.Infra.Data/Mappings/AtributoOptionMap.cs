using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class AtributoOptionMap : EntityMap<AtributoOption>
{
    public void Configure(EntityTypeBuilder<AtributoOption> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Quantidade)
            .HasColumnType("INT");

        builder.Property(a => a.OptionName)
            .HasColumnType("VARCHAR");
    }
}