namespace UZUSIS.Domain.Entities;

public class Cliente : Pessoa
{
    protected Cliente()
    {
        
    }

    public Cliente(string nome, string cpf, string email, string password, string role) : base(nome, cpf, email, password, role)
    {
        Erros = Validate();
    }
    public Carrinho Carrinho { get; set; }

  
}