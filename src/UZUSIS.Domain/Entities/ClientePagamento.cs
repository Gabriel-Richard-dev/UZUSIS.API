namespace UZUSIS.Domain.Entities;

public class ClientePagamento : Entity
{
    public Usuario Cliente { get; set; }
    public Pagamento Pagamento { get; set; }
}