namespace UZUSIS.Application.DTO.Admin;

public class AdminLoginDTO
{
    public AdminLoginDTO(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}