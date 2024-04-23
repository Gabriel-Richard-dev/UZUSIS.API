namespace UZUSIS.Domain.Entities;

public class Atributo : Entity
{
    public string Title { get; set; }
    public ICollection<SeletorOption>? AtributoOptions { get; set; }
    
}