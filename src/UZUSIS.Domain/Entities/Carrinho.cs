namespace UZUSIS.Domain.Entities;

public class Carrinho : Entity
{
    
    public List<Produto> Produtos { get; set; }
    public Cliente Cliente { get; set; }
    
}