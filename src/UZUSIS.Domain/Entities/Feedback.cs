using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Enumerations;

namespace UZUSIS.Domain.Entities;

public class Feedback : Entity
{
    public List<Produto> Produtos { get; set; }
    public Usuario Cliente { get; set; }
    public String Stars { get; set; }

    public void Classifique(short stars)
    {
        switch (stars)
        {
            case 0:
                Stars = EFeedback.Pessimo.ToString(); break;
            case 1:
                Stars = EFeedback.Ruim.ToString(); break;
            case 2:
                Stars = EFeedback.Aceitavel.ToString(); break;
            case 3:
                Stars = EFeedback.Bom.ToString(); break;
            case 4:
                Stars = EFeedback.Excelente.ToString(); break;
        }
    }
    

}