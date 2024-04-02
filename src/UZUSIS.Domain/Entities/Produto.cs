namespace UZUSIS.Domain.Entities;

public class Produto : Entity
{
    public Produto(byte[]? photo64, string nome, string descricao, bool isDisponivel, string tipo, string tamanho, string cor, string tag, decimal preco)
    {
        Photo64 = photo64;
        Nome = nome;
        Descricao = descricao;
        this.isDisponivel = isDisponivel;
        Tipo = tipo;
        Tamanho = tamanho;
        Cor = cor;
        Tag = tag;
        Preco = preco;
    }

    public byte[]? Photo64 { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool isDisponivel { get; set; }
    public string Tipo { get; set; }
    public string Tamanho { get; set; }
    public string Cor { get; set; }
    public string Tag { get; set; }
    
    public string IdentificadorGrupo { get; set; }
    
    public decimal Preco { get; set; }
}