using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Infra.Data.Mappings;

public class ClientePagamentoMap : EntityMap<ClientePagamento>
{

    public void Configure(EntityTypeBuilder<ClientePagamento> builder)
    {
        builder.ToTable("ClientePagamento");

        builder.HasOne(cp => cp.Cliente);

        builder.HasOne(cp => cp.Pagamento);
        
    }
}