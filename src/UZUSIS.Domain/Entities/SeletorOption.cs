namespace UZUSIS.Domain.Entities;

public class SeletorOption : Entity
{
    public string SeletorOptionTitle { get; set; }
    public byte[]? Foto { get; set; }
    public Atributo Atributo { get; set; }

}