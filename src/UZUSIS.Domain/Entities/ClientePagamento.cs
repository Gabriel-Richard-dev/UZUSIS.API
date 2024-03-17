namespace UZUSIS.Domain.Entities;

public class ClientePagamento
{
    public Cliente Cliente { get; set; }
    public Pagamento Pagamento { get; set; }
}