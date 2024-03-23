namespace UZUSIS.Domain.Entities;

public class Carrinho : Entity
{
    public long UserId { get; set; }
    public decimal valorTotal { get; set; }

    public List<Produto> Produtos { get; set; } = new();
    public Usuario Cliente { get; set; }
    
}