namespace UZUSIS.Domain.Entities;

public class Atributo : Entity
{
    public string AtributoTitle { get; set; }
    public List<AtributoOption> AtributoOptions { get; set; } = new();
}