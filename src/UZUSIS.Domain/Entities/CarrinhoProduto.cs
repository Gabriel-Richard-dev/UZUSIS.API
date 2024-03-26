namespace UZUSIS.Domain.Entities;

public class CarrinhoProduto : Entity
{
    
    public Carrinho Carrinho { get; set; }
    public Produto Produto { get; set; }
}