using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Core.Criptografy;
using UZUSIS.Application.DTO;
using UZUSIS.Application.Services;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class AuthController : BaseController
{
    public AuthController(INotification notification, IAuthService authenticationService, IUsuarioService usuarioService, ICarrinhoSevice carrinhoSevice, ITokenService tokenService) : base(notification)
    {
        _authenticationService = authenticationService;
        _usuarioService = usuarioService;
        _carrinhoSevice = carrinhoSevice;
        _tokenService = tokenService;
    }

    private readonly IAuthService _authenticationService;
    private readonly IUsuarioService _usuarioService;
    private readonly ICarrinhoSevice _carrinhoSevice;
    private readonly ITokenService _tokenService;
    
    [HttpGet]
    [Route("login")]
    public async Task<IActionResult> Login()
    {
        await _authenticationService.isAuthenticationValid();
        return CustomResponse();
    }
    
    [HttpPost]
    [Route("cadastro")]
    public async Task<IActionResult> Cadastro(UsuarioDTO dto)
    {
        dto.Role = "cliente";
        var userCreated = await _usuarioService.Create(dto);
        var carrinhoCreated = await _carrinhoSevice.CreateCarrinho(userCreated);
        return CustomResponse(new Object[] {userCreated!, carrinhoCreated!});
    }

    [HttpPut]
    [Route("recovery-password")]
    public async Task<IActionResult> RecuperarSenha()
    {
        return CustomResponse();
    }


}