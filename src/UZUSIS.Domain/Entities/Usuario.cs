using UZUSIS.Domain.Validators;

namespace UZUSIS.Domain.Entities;

public class Usuario  : Entity
{
    public Usuario(string photoUrl, string nome, string cpf, char genero,
        string email, string password, string role, string tamanho, DateTime dataNascimento)
    {
        PhotoUrl = photoUrl;
        Nome = nome;
        CPF = cpf;
        Genero = genero;
        Email = email;
        Password = password;
        Role = role;
        Tamanho = tamanho;
        DataNascimento = dataNascimento;
    }

    protected Usuario()
    {
        
    }

    public string PhotoUrl { get; set; }
    public string Nome { get; private set; }
    public string CPF { get; set; }
    
    public char Genero { get; set; }
    public string Email { get; set; }
    public string Password { get; private set; }
    public string Role { get; set; }
    public string Tamanho { get; set; }
    
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
