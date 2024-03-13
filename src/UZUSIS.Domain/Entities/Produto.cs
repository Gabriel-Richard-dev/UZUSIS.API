namespace UZUSIS.Domain.Entities;

public class Produto : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool isDisponivel { get; set; }
    public string Tipo { get; set; }
    public double Tamanho { get; set; }
    public string Cor { get; set; }
    public string Tag { get; set; }
    public decimal Preco { get; set; }
}