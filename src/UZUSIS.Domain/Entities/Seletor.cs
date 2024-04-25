namespace UZUSIS.Domain.Entities;

public class Seletor : Entity
{
    protected Seletor() { }
    public Seletor(string title, List<SeletorOption> seletorOptions)
    {
        Title = title;
        SeletorOptions = seletorOptions;
    }

    public string Title { get; set; }
    public List<SeletorOption> SeletorOptions { get; set; }
}