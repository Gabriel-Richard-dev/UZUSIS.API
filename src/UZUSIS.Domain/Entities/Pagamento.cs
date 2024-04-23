using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace UZUSIS.Domain.Entities;

public class Pagamento : Entity
{
    protected Pagamento(){ }
    public Pagamento(decimal valorTotal, Collection<Produto> produtos, DateTime dataDePagamento, DateTime expires)
    {
        ValorTotal = valorTotal;
        Produtos = produtos;
        DataCriacao = DateTime.Now;
        DataEmissao = DateTime.Now;
        Expires = DateTime.Now.AddDays(3);
    }


    public decimal ValorTotal { get; set; }
    public Collection<Produto> Produtos { get; set; }
    public DateTime DataEmissao { get; set; }
    public DateTime DataDePagamento { get; set; }
    public DateTime Expires { get; set; }



    public async Task Pagar()
    {
        DataAtualizacao = DateTime.Now;
        DataDePagamento = DateTime.Now;
    }
    
    
}