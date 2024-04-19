namespace UZUSIS.Domain.Entities;

public class Atributo : Entity
{
    public string Title { get; set; }
    public List<AtributoOption> AtributoOptions { get; set; } = new();
    
}