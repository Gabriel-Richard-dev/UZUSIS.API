using System.Collections.ObjectModel;

namespace UZUSIS.Domain.Entities;

public class HistoricoPagamento : Entity
{
    public Collection<Pagamento> Pagamentos { get; set; }

}