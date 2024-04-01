using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.DTO;

public class CarrinhoDTO : BaseDTO
{
    public long UserId { get; set; }
    public decimal valorTotal { get; set; }

    public List<Produto> Produtos { get; set; } = new();
    public Usuario Cliente { get; set; }
}