using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class ClienteMap : EntityMap<Cliente>
{
    
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");
        
        builder.Property(c => c.Nome)
            .IsRequired()
            .HasColumnType("VARCHAR(80)");

        builder.Property(c => c.Role)
            .IsRequired()
            .HasDefaultValue("Admin")
            .HasColumnType("VARCHAR(11)");
        
        builder.Property(c => c.Email)
            .IsRequired()
            .HasColumnType("VARCHAR(180)");
        
        builder.HasIndex(c => c.Email)
            .IsUnique();

        builder.HasIndex(c => c.CPF)
            .IsUnique();

        builder.Property(c => c.CPF)
            .IsRequired()
            .HasColumnType("VARCHAR(11)");

        builder.Property(c => c.Password)
            .IsRequired();

        builder
            .HasOne(c => c.Carrinho)
            .WithOne(c => c.Cliente)
            .OnDelete(DeleteBehavior.Cascade);
    }
}