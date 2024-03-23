namespace UZUSIS.Domain.Entities;

public class ProdutoCarrinho : Entity
{
    public ProdutoCarrinho(long produtoId, long carrinhoId, long valorTotal, long quantidade, Carrinho carrinho, Produto produto)
    {
        ProdutoId = produtoId;
        CarrinhoId = carrinhoId;
        this.valorTotal = valorTotal;
        this.quantidade = quantidade;
        Carrinho = carrinho;
        Produto = produto;
    }

    public long ProdutoId { get; set; }
    public long CarrinhoId { get; set; }
    public decimal valorTotal { get; set; }
    public long quantidade { get; set; }

    public Carrinho Carrinho { get; set; }
    public Produto Produto { get; set; }



}