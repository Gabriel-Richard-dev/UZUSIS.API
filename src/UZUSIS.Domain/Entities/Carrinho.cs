namespace UZUSIS.Domain.Entities;

public class Carrinho : Entity
{
    public decimal valorTotal { get; set; }
    public List<Produto> Produtos { get; set; } = new();
    public Usuario Cliente { get; set; }

    public void AdicionarAoCarrinho(Produto produto)
    {
        Produtos.Add(produto);
    }
    
    public void AdicionarAoCarrinho(List<Produto> produtos)
    {
        foreach (var p in produtos)
        {
            produtos.Add(p);
        }
    }
    public void RemoverDoCarrinho(Produto produto)
    {
        Produtos.Remove(produto);
    }
    public void RemoverDoCarrinho(List<Produto> produtos)
    {
        foreach (var p in produtos)
        {
            Produtos.Remove(p);
        }
    }

    public decimal ValorTotal()
    {
        decimal total = 0m;
        foreach (var produto in Produtos)
        {
            total += produto.Preco;
        }

        return total;
    }
    
}