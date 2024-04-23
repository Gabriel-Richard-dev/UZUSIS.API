﻿using Microsoft.EntityFrameworkCore;
using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Mappings;

namespace UZUSIS.Infra.Data.Context;

public class UZUSISContext : DbContext, IUnityOfWork
{

    public UZUSISContext()
    {
        
    }
    
    public UZUSISContext(DbContextOptions<UZUSISContext> options) : base(options)
    { }
    

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connection = "server=localhost; port=3306;database=UZUSIS; uid=root;password=";
        options.UseMySql(connection, ServerVersion.AutoDetect(connection));
        options.EnableDetailedErrors();
    }
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pagamento> Payments { get; set; }
    public DbSet<Pagamento> Grupos { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      
        builder.ApplyConfiguration(new AtributoMap());
        builder.ApplyConfiguration(new CarrinhoMap());
        builder.ApplyConfiguration(new CarrinhoProdutoMap());
        builder.ApplyConfiguration(new FavoritoMap());
        builder.ApplyConfiguration(new FeedbackMap());
        builder.ApplyConfiguration(new HistoricoPagamentoMap());
        builder.ApplyConfiguration(new PagamentoMap());
        builder.ApplyConfiguration(new ProdutoMap());
        builder.ApplyConfiguration(new SeletorMap());
        builder.ApplyConfiguration(new SeletorOptionOptionMap());
        builder.ApplyConfiguration(new UsuarioMap());
    }
    
    
    
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;
}