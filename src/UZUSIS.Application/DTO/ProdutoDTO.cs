namespace UZUSIS.Application.DTO;

public class ProdutoDTO : BaseDTO
{
    public string PhotoUrl { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool isDisponivel { get; set; }
    public string Tipo { get; set; }
    public string Tamanho { get; set; }
    public string Cor { get; set; }
    public string Tag { get; set; }
    public decimal Preco { get; set; }
}