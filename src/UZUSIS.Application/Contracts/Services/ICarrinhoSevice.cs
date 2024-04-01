using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface ICarrinhoSevice : IBaseService<Carrinho>
{
    Task<Carrinho?> CreateCarrinho(Usuario user);
}
