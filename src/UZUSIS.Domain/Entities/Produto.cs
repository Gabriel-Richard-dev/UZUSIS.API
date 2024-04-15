namespace UZUSIS.Domain.Entities;

public class Produto : Entity
{
    public List<byte[]?> Photos { get; set; } = new();
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool isDisponivel { get; set; }

    public bool isEsgotado { get; set; }
    public string Tag { get; set; }
    public List<Atributo> Atributos { get; set; }

    public Seletor Seletor { get; set; }    
    public decimal Preco { get; set; }
    

}