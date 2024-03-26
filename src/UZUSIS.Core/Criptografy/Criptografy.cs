using System.Security.Cryptography;
using System.Text;


namespace UZUSIS.Core.Criptografy;

public static class Criptografy
{

    public static string HashPassword(this string password)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

        var stringBuilder = new StringBuilder();

        foreach (var b in bytes)
        {
            stringBuilder.Append(b.ToString("x2"));
        }

        return stringBuilder.ToString();

    }
    
    
}