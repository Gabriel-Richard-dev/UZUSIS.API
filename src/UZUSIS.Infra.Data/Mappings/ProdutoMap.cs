﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class ProdutoMap : EntityMap<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produto");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("BIGINT");

        builder.Property(p => p.Photo64);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("VARCHAR");

        builder.Property(p => p.Descricao)
            .HasColumnType("VARCHAR");

        builder.Property(p => p.isDisponivel)
            .HasColumnType("BIT")
            .HasDefaultValue(1);

        builder.Property(p => p.Tipo)
            .HasColumnType("VARCHAR");

        builder.Property(p => p.Tamanho)
            .HasColumnType("VARCHAR(2)");

        builder.Property(p => p.Cor)
            .HasColumnType("VARCHAR");

        builder.Property(p => p.Tag)
            .HasColumnType("VARCHAR")
            .HasDefaultValue("new");

        builder.Property(p => p.Preco)
            .IsRequired()
            .HasColumnType("DECIMAL(10,2)");
        
        builder.Property(u => u.DataCriacao)
            .IsRequired()
            .HasColumnType("DATE")
            .HasDefaultValue(DateTime.Now.ToString("yyyy/MM/dd"));

        builder.Property(u => u.DataAtualizacao)
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now);

    }    
}