using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Application.DTO.Seletor;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class ProdutoController : BaseController
{
    public ProdutoController(INotification notification, IProdutoService produtoService) : base(notification)
    {
        _produtoService = produtoService;
    }

    private readonly IProdutoService _produtoService;
 
    
    
    [HttpPost]
    [Route("cadastrar-produto")]
    // [Authorize(Roles = "admin")]
    public async Task<IActionResult> CadastrarProduto([FromBody]ProdutoDTO dto)
    {
        var prod = await _produtoService.Create(dto);
        return CustomResponse(prod);
    }


    [HttpGet]
    [Route("search/{parseName}")]
    public async Task<IActionResult> Search(string dto)
    {
        return CustomResponse(_produtoService.Search(dto));
    }
    
    
}