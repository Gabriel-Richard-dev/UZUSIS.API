namespace UZUSIS.Domain.Entities;

public class GrupoProduto
{
    public Grupo Grupo { get; set; }
    public List<Produto> Produtos { get; set; } = new();

    public int QuantidadeDeProdutos => Produtos.Count;
    
}

