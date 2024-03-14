using UZUSIS.Domain.Validators;

namespace UZUSIS.Domain.Entities;

public abstract class Pessoa : Entity
{
    protected Pessoa()
    {
        
    }
    public Pessoa(string nome, string cpf, string email, string password, string role)
    {
        Nome = nome;
        CPF = cpf;
        Email = email;
        Password = password;
        Role = role;
        Erros = Validate();
    }

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


    public List<string?>? Validate()
    {
        var validator = new PessoaValidator();
        var validatorResult = validator.Validate(this);

        if (validatorResult is not null)
            return null;
        
        var listErros = validatorResult?.Errors.ToList();
        List<string?>? stringListErros = new();
        
        listErros?.ForEach(erro => stringListErros.Add(erro.ToString()));
        
        return stringListErros;
        
    }
    
}
