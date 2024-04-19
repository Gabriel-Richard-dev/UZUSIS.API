using UZUSIS.Core.Criptografy;
using UZUSIS.Domain.Validators;

namespace UZUSIS.Domain.Entities;

public class Usuario  : Entity
{
    public Usuario(string nome)
    {
        Nome = nome;
        Validate();
        CriptografyPass();
    }

    protected Usuario()
    {
        
    }
    
    public string Nome { get; private set; }
    public string CPF { get; set; }
    
    public string Email { get; set; }
    public string Password { get; private set; }
    public string Role { get; set; }
    
    public DateTime DataNascimento { get; set; }


    public void AtualizaNome(string nome)
    {
        Nome = nome;
        Validate();
    }

    public void AtualizaPassword(string newpass)
    {
        Password = newpass;
        Validate();
        CriptografyPass();
    }


    public void CriptografyPass()
    {   
        Password = Password.HashPassword();
    }


    public List<string?>? Validate()
    {
        var validator = new UsuarioValidator();
        var validatorResult = validator.Validate(this);

        if (validatorResult is not null)
            return null;
        
        var listErros = validatorResult?.Errors.ToList();
        List<string?>? stringListErros = new();
        
        listErros?.ForEach(erro => stringListErros.Add(erro.ToString()));
        
        return stringListErros;
        
    }
    
}
