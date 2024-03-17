using System.Collections.ObjectModel;

namespace UZUSIS.Domain.Entities;

public class Payment : Entity
{
    public Guid RastreadorDePedido { get; set; }
    public Cliente Cliente { get; set; }
    public Collection<Produto> Produtos { get; set; }
    public DateTime DataDeLancamento { get; set; }
    public DateTime DataDePagamento { get; set; }
    public DateTime Expires { get; set; }
}