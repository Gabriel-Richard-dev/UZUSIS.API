using FluentValidation;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Domain.Validators;

public class EntityValidator : AbstractValidator<Entity> 
{
    public EntityValidator()
    {   
        RuleFor(e => e.Id).NotEmpty().NotNull();
        RuleFor(e => e.DataCriacao).NotEmpty().NotNull();
    }
}