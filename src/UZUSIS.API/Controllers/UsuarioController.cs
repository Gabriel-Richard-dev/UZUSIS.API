using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class UsuarioController : BaseController
{
    public UsuarioController(INotification notification, IUsuarioService usuarioService) : base(notification)
    {
        _usuarioService = usuarioService;
    }

    private readonly IUsuarioService _usuarioService;
    
    [HttpGet]
    [Route("adicionar-ao-carrinho")]
    public async Task<IActionResult> AdicionarAoCarrinho()
    {
        return CustomResponse("oi");
    }
    [HttpPost]
    [Route("criar")]
    public async Task<IActionResult> CriarUsuario()
    {
        return CustomResponse(await _usuarioService.Create(new UsuarioDTO()));
    }
}
