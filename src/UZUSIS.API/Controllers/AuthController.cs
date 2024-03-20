using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("/")]
public class AuthController : BaseController
{
    public AuthController(INotification notification, IAuthService authenticationService) : base(notification)
    {
        _authenticationService = authenticationService;
    }

    private readonly IAuthService _authenticationService;
    [HttpGet]
    [Route("/auth")]
    public async Task<IActionResult> Authenticate([FromBody]ClienteDTO clienteDto)
    {
        var response = await _authenticationService.isAuthenticationValid();
        return CustomResponse(response);
    }



}