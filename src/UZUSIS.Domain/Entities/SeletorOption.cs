namespace UZUSIS.Domain.Entities;

public class SeletorOption : Entity
{
    protected SeletorOption() { }
    public SeletorOption(string seletorName, byte[]? foto, Atributo atributo)
    {
        SeletorName = seletorName;
        Foto = foto;
        Atributo = atributo;
    }

    public string SeletorName { get; set; }
    public byte[]? Foto { get; set; }
    public Atributo Atributo { get; set; }

}