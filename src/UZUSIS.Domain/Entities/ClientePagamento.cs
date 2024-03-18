namespace UZUSIS.Domain.Entities;

public class ClientePagamento : Entity
{
    public Cliente Cliente { get; set; }
    public Pagamento Pagamento { get; set; }
}