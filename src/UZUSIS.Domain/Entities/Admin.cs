namespace UZUSIS.Domain.Entities;

public class Admin : Pessoa
{
    protected Admin()
    {
        
    }

    public Admin(string nome, string cpf, string email, string password, string role) : base(nome, cpf, email, password, role)
    {
        Erros = Validate();
    }
}