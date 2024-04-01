using System.Collections.ObjectModel;

namespace UZUSIS.Domain.Entities;

public class Favorito : Entity
{
    public Usuario Cliente { get; set; }
    public Collection<Produto> Produtos { get; set; } = new();


    public void AdicionarAosFavoritos(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void AdicionarAosFavoritos(List<Produto> produtos)
    {
        foreach (var p in produtos)
        {
            Produtos.Add(p);
        }
    }


    public void RemoverDosFavoritos(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public void RemoverDosFavoritos(List<Produto> produtos)
    {
        foreach (var p in produtos)
        {
            Produtos.Remove(p);
        }
        
    }
    
    
    
    
}