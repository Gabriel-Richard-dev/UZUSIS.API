using Microsoft.EntityFrameworkCore;
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
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pagamento> Payments { get; set; }
    public DbSet<Pagamento> Grupos { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
      
        builder.ApplyConfiguration(new UsuarioMap());
        builder.ApplyConfiguration(new CarrinhoMap());
        builder.ApplyConfiguration(new CarrinhoProdutoMap());
        builder.ApplyConfiguration(new ProdutoMap());
        builder.ApplyConfiguration(new GrupoMap());
        builder.ApplyConfiguration(new PagamentoMap());
        builder.ApplyConfiguration(new FeedbackMap());
    }
    
    
    
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;
}