using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Entities;


namespace UZUSIS.Application.Services;

public class TokenService : BaseService, ITokenService
{
    public TokenService(Notification notification, IMapper mapper) : base(notification, mapper)
    {
    }

    public string GenerateToken(PessoaDTO pessoa)
    {
        var key = Encoding.ASCII.GetBytes(UZUSIS.Domain.Keys.Key.Secret);
        var tokenConfig = new SecurityTokenDescriptor
        {
            Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
            {
                new Claim("userId", pessoa.Id.ToString()),
                new Claim(ClaimTypes.Role, pessoa.Role)
            }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var parseToken = tokenHandler.CreateToken(tokenConfig);
        var token = tokenHandler.WriteToken(parseToken);

        return token;
    }

    public static long GetUserIdByToken(string token_recevied)
    {
        var token = token_recevied.Replace("Bearer", "").Trim();
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);
        var id = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId").Value;
        
        
        var longId = long.Parse(id);

        return longId;
    }
    
    
    
    
    
    
    
    
    
}