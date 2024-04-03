namespace UZUSIS.Domain.Entities;

public class Grupo : Entity
{
    public string IdentificadorGrupo { get; set; }
    public List<Produto> Produtos = new List<Produto>();
}