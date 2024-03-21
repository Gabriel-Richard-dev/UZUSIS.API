using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.Criptografy;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("/auth")]
public class AuthController : BaseController
{
    public AuthController(INotification notification, IAuthService authenticationService) : base(notification)
    {
        _authenticationService = authenticationService;
    }

    private readonly IAuthService _authenticationService;
    
    
    [HttpGet]
    [Route("login")]
    public async Task<IActionResult> Login()
    {
        return CustomResponse();
    }
    
    [HttpPost]
    [Route("cadastro")]
    public async Task<IActionResult> Cadastro()
    {
        return CustomResponse();
    }

    [HttpPut]
    [Route("recovery-password")]
    public async Task<IActionResult> RecuperarSenha()
    {
        return CustomResponse();
    }
}