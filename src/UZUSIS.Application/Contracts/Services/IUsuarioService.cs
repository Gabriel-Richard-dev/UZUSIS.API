using UZUSIS.Application.DTO;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IUsuarioService : IBaseService<Usuario>
{
    
    Task<Usuario?> Create<DTO>(DTO dto) where DTO : BaseDTO;
    Task<bool> CommitChanges();
}