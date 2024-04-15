using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Entities;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class UsuarioController : BaseController
{
    public UsuarioController(INotification notification, IUsuarioService usuarioService, IFeedbackService feedbackService) : base(notification)
    {
        _usuarioService = usuarioService;
        _feedbackService = feedbackService;
    }

    private readonly IUsuarioService _usuarioService;
    private readonly IFeedbackService _feedbackService;

    [HttpGet]
    [Route("deixar-feedback")]
    public async Task<IActionResult> DeixarFeedback(FeedbackDTO feedback)
    {
        return Ok(await _feedbackService.Create(feedback));
    }

    [HttpPost]
    [Route("adicionar-ao-carrinho")]
    public async Task<IActionResult> AdicionarAoCarrinho(Produto produto)
    {
        return Ok();
    }
    
    [HttpDelete]
    [Route("remover-do-carrinho")]
    public async Task<IActionResult> RemoverDoCarrinho(Produto produto)
    {
        return Ok();
    }
    
    
    
}
