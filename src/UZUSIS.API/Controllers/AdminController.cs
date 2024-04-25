using System.Xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class AdminController : BaseController
{
    public AdminController(INotification notification, IUsuarioService usuarioService,
        IProdutoService produtoService, ICarrinhoSevice carrinhoSevice) : base(notification)
    {
        _usuarioService = usuarioService;
        _produtoService = produtoService;
        _carrinhoSevice = carrinhoSevice;
    }

    private readonly IUsuarioService _usuarioService;
    private readonly IProdutoService _produtoService;
    private readonly ICarrinhoSevice _carrinhoSevice;
    
    
    [Route("cadastrar-cliente")]
    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastarCliente(UsuarioDTO dto)
    {
        dto.Role = "cliente";
        var userCreated = await _usuarioService.Create(dto);
        var carrinhoCreated = await _carrinhoSevice.CreateCarrinho(userCreated);
        return CustomResponse(new Object[] {userCreated!, carrinhoCreated!});
    }
 
    
}