using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class UsuarioMap : EntityMap<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");

        builder.HasKey(u => u.Id);
  
        builder.Property(u => u.Nome)
            .IsRequired()
            .HasColumnType("VARCHAR(80)");

        builder.HasIndex(u => u.CPF)
            .IsUnique();

        builder.Property(u => u.CPF)
            .IsRequired()
            .HasColumnType("VARCHAR(11)");


        builder.Property(u => u.Email)
            .IsRequired()
            .HasColumnType("VARCHAR(180)");
        
        builder.HasIndex(u => u.Email)
            .IsUnique();
        
        builder.Property(u => u.Password)
            .IsRequired();
        
        builder.Property(u => u.Role)
            .IsRequired()
            .HasDefaultValue("cliente")
            .HasColumnType("VARCHAR(11)");
       
        builder.Property(u => u.DataNascimento)
            .IsRequired()
            .HasColumnType("DATE");

        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);
        
    }
}