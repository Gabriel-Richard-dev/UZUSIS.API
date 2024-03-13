using UZUSIS.Domain.Validators;

namespace UZUSIS.Domain.Entities;

public abstract class Pessoa : Entity
{
    public string Nome { get; private set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Password { get; private set; }
    public string Role { get; set; }


    public void AtualizaNome(string nome)
    {
        Nome = nome;
    }

    public void AtualizaPassword(string newpass)
    {
        Password = newpass;
    }


    public bool Validate()
    {
        var validator = new PessoaValidator();
        var validatorResult = validator.Validate(this);

        if (validatorResult is not null)
            return true;

        return false;

    }
    
    
}
