namespace UZUSIS.Domain.Entities;

public class Produto : Entity
{
    protected Produto(){ }
    public Produto(string nome, string descricao, bool isDisponivel, bool isEsgotado, string tag, Seletor seletor, decimal preco)
    {
        Nome = nome;
        Descricao = descricao;
        this.isDisponivel = isDisponivel;
        this.isEsgotado = isEsgotado;
        Tag = tag;
        Seletor = seletor;
        Preco = preco;
    }

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool isDisponivel { get; set; }

    public bool isEsgotado { get; set; }
    public string Tag { get; set; }
    
    public Seletor Seletor { get; set; }    

    public decimal Preco { get; set; }
    

}