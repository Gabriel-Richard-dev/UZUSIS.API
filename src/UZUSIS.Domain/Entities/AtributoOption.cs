namespace UZUSIS.Domain.Entities;

public class AtributoOption : Entity
{
    protected AtributoOption(){ }
    public AtributoOption(string optionName, int quantidade)
    {
        OptionName = optionName;
        Quantidade = quantidade;
    }

    public string OptionName { get; set; }
    public int Quantidade { get; set; }
}