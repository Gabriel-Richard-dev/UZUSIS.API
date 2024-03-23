using System.Numerics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Mappings;

namespace UZUSIS.Infra.Data.Context;

public class UZUSISContext : DbContext, IUnityOfWork
{

    public UZUSISContext()
    { }

    public UZUSISContext(DbContextOptions<UZUSISContext> options) : base(options)
    { }
    

    public UZUSISContext(DbContextOptionsBuilder options)
    {
        options.EnableDetailedErrors();
    }
    
    private DbSet<Usuario> Usuarios { get; set; }
    private DbSet<Carrinho> Carrinhos { get; set; }
    private DbSet<Produto> Produtos { get; set; }
    private DbSet<Pagamento> Payments { get; set; }

    
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      
        builder.ApplyConfiguration(new UsuarioMap());
        builder.ApplyConfiguration(new CarrinhoMap());
        builder.ApplyConfiguration(new ProdutoMap());
        builder.ApplyConfiguration(new PagamentoMap());
        builder.ApplyConfiguration(new ClientePagamentoMap());
    }
    
    
    
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;
}