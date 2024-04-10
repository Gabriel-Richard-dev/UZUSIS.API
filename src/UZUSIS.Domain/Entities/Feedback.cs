using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Enumerations;

namespace UZUSIS.Domain.Entities;

public class Feedback : Entity
{
    public Produto Produto { get; set; }
    public Usuario Cliente { get; set; }
    public short Stars { get; set; }
    public string Message { get; set; }

    public void Classifique(short stars, string message)
    {
        switch (stars)
        {
            case 0:
                Stars = (int)EFeedback.Pessimo; break;
            case 1:
                Stars = (int)EFeedback.Ruim; break;
            case 2:
                Stars = (int)EFeedback.Aceitavel; break;
            case 3:
                Stars = (int)EFeedback.Bom; break;
            case 4:
                Stars = (int)EFeedback.Excelente; break;
        }

        Message = message;

    }
    

}