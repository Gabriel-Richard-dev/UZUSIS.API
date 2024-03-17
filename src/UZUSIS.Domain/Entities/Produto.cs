namespace UZUSIS.Domain.Entities;

public class Produto : Entity
{
    public Produto(string photoUrl, string nome, string descricao, bool isDisponivel, string tipo, string tamanho, string cor, string tag, decimal preco)
    {
        PhotoUrl = photoUrl;
        Nome = nome;
        Descricao = descricao;
        this.isDisponivel = isDisponivel;
        Tipo = tipo;
        Tamanho = tamanho;
        Cor = cor;
        Tag = tag;
        Preco = preco;
    }

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