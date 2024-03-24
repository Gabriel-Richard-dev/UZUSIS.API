using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("/admin")]
public class AdminController : BaseController
{
    public AdminController(INotification notification, IUsuarioService usuarioService) : base(notification)
    {
        _usuarioService = usuarioService;
    }

    private readonly IUsuarioService _usuarioService;
    
    
    [Route("cadastrar-cliente")]
    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastarCliente()
    {
        return CustomResponse(await _usuarioService.Create());
    }
    
    [Route("cadastrar-admin")]
    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastrarAdmin()
    {
        return CustomResponse();
    }

    [Route("cadastrar-produto")]
    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastrarProduto()
    {
        return CustomResponse();
    }

    [Route("produtos")]
    [HttpGet]
    public async Task<IActionResult> GetProdutos()
    {
        return CustomResponse();
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}