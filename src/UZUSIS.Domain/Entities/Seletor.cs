namespace UZUSIS.Domain.Entities;

public class Seletor : Entity
{
    public string Title { get; set; }
    public List<SeletorOption> SeletorOptions { get; set; }
}