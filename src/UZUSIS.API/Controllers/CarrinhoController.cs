using Microsoft.AspNetCore.Mvc;
using UZUSIS.Application;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarrinhoController : BaseController
{
    public CarrinhoController(INotification notification) : base(notification)
    {
    }
    
}