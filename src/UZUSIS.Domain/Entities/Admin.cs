namespace UZUSIS.Domain.Entities;

public class Admin : Pessoa
{
    protected Admin() { }

    public Admin(string photoUrl, string nome, string cpf, char genero,
        string email, string password, string role, string tamanho,
        DateTime dataNascimento)
        : base(photoUrl, nome, cpf, genero, email, password, role, tamanho, dataNascimento)
    {
    }
}