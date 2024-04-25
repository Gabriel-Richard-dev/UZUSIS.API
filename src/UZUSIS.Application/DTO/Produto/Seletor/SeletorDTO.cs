namespace UZUSIS.Application.DTO.Seletor;

public class SeletorDTO : BaseDTO
{

    public string Title { get; set; }
    public List<SeletorOptionDTO> SeletorOptions { get; set; }
}