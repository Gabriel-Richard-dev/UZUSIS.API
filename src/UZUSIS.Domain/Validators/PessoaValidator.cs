using FluentValidation;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Domain.Validators;

public class PessoaValidator : AbstractValidator<Pessoa>
{
    public PessoaValidator()
    {
        RuleFor(p => p.Nome)
            .NotNull()
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(90);
        RuleFor(p => p.CPF)
            .NotNull()
            .NotEmpty()
            .Length(11);
        RuleFor(p => p.Email)
            .NotNull()
            .NotEmpty()
            .MinimumLength(7)
            .MaximumLength(180)
            .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        RuleFor(p => p.Role)
            .NotEmpty()
            .NotNull();
        


    }
}
