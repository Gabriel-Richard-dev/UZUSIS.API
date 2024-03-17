﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class AdminMap : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable("Admin");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .HasColumnType("BIGINT")
            .ValueGeneratedOnAdd();

        builder.Property(a => a.Nome)
            .IsRequired()
            .HasColumnType("VARCHAR(80)");

        builder.Property(a => a.Role)
            .IsRequired()
            .HasDefaultValue("Admin")
            .HasColumnType("VARCHAR(11)");
        
        builder.Property(a => a.Email)
            .IsRequired()
            .HasColumnType("VARCHAR(180)");
        
        builder.HasIndex(a => a.Email)
            .IsUnique();

        builder.HasIndex(a => a.CPF)
            .IsUnique();

        builder.Property(a => a.CPF)
            .IsRequired()
            .HasColumnType("VARCHAR(11)");

        builder.Property(a => a.Password)
            .IsRequired();

    }
}