namespace UZUSIS.Domain.Entities;

public class Cliente : Pessoa
{
    protected Cliente()
    { }

    public Cliente(string photoUrl, string nome, string cpf, char genero, string email,
        string password, string role, string tamanho,
        DateTime dataNascimento, Carrinho carrinho)
        : base(photoUrl, nome, cpf, genero, email, password, role, tamanho, dataNascimento)
    {
        Carrinho = carrinho;
    }

    public Carrinho Carrinho { get; set; }
    
}