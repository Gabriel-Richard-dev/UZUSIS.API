using System.Collections.ObjectModel;

namespace UZUSIS.Domain.Entities;

public class Favorito : Entity
{
    public Usuario Cliente { get; set; }
    public Collection<Produto> Produtos { get; set; } = new();
    
}