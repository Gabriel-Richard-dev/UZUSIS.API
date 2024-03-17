using System.Collections.ObjectModel;

namespace UZUSIS.Domain.Entities;

public class Favoritos
{
    public Cliente Cliente { get; set; }
    public Collection<Produto> Produtos { get; set; }
}