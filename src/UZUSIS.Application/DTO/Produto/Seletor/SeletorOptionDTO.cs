namespace UZUSIS.Application.DTO.Seletor;

public class SeletorOptionDTO : BaseDTO
{

    public string SeletorName { get; set; }
    public byte[]? Foto { get; set; }
    public AtributoDTO Atributo { get; set; }

}