using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Validators;

namespace UZUSIS.Domain.Entities;

public abstract class Entity : IEntity
{
    public long Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public List<string?>? Erros { get; set; } = new ();
    
    public List<string?>? Validate()
    {
        var validator = new EntityValidator();
        var validatorResult = validator.Validate(this);

        if (validatorResult is not null)
            return null;
        
        var listErros = validatorResult?.Errors.ToList();
        List<string?>? stringListErros = new();
        
        listErros?.ForEach(erro => stringListErros.Add(erro.ToString()));
        
        return stringListErros;

    }

    
    
}