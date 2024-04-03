using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class ProdutoController : BaseController
{
    public ProdutoController(INotification notification, IProdutoService produtoService, IGrupoService grupoService) : base(notification)
    {
        _produtoService = produtoService;
        _grupoService = grupoService;
    }

    private readonly IProdutoService _produtoService;
    private readonly IGrupoService _grupoService;
    
    
    [HttpPost]
    [Route("cadastrar-produto")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastrarProduto(ProdutoDTO dto)
    {
        return CustomResponse(await _produtoService.Create(dto));
    }

    [HttpPost]
    [Route("cadastrar-grupo")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastrarGrupo(GrupoDTO dto)
    {
        return CustomResponse(await _grupoService.Create(dto));
    }

    [HttpGet]
    [Route("search/{parseName}")]
    public async Task<IActionResult> Search(string parseName)
    {
        return CustomResponse(await _produtoService.Get(parseName));
    }
}