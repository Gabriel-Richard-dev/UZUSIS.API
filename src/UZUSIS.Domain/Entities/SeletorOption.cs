namespace UZUSIS.Domain.Entities;

public class SeletorOption : Entity
{
    public string SeletorName { get; set; }
    public byte[]? Foto { get; set; }
    public Atributo Atributo { get; set; }

}