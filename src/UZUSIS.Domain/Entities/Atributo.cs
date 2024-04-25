namespace UZUSIS.Domain.Entities;

public class Atributo : Entity
{
    protected Atributo(){ }
    public Atributo(string title, List<AtributoOption> atributoOptions)
    {
        Title = title;
        AtributoOptions = atributoOptions;
    }

    public string Title { get; set; }
    public List<AtributoOption> AtributoOptions { get; set; }
    
}