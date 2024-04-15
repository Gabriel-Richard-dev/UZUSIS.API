using System.Data;
using FluentValidation;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Domain.Validators;

public class ProdutoValidator : AbstractValidator<Produto>
{
    public ProdutoValidator()
    {
        RuleFor(p => p.Nome)
            .NotNull()
            .NotEmpty()
            .MaximumLength(80);
        RuleFor(p => p.Descricao)
            .NotNull()
            .NotEmpty()
            .MaximumLength(300);
        RuleFor(p => p.isDisponivel)
            .NotNull()
            .NotEmpty();
        
        
        RuleFor(p => p.Tag)
            .NotNull()
            .NotEmpty();
        RuleFor(p => p.Preco)
            .NotNull()
            .NotEmpty();
        
    }
}