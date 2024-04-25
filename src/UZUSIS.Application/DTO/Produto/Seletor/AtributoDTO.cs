
namespace UZUSIS.Application.DTO.Seletor;

public class AtributoDTO
{


    public string Title { get; set; }
    public ICollection<AtributoOptionDTO>? AtributoOptions { get; set; }
}