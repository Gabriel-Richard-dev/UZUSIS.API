using UZUSIS.Application.DTO.Seletor;

namespace UZUSIS.Application.DTO;

public class ProdutoDTO : BaseDTO
{
  
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Tag { get; set; }
    public SeletorDTO Seletor { get; set; }
    public decimal Preco { get; set; }
}