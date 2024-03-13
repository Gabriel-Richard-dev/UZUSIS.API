using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using UZUSIS.Application;

namespace UZUSIS.API.Controllers;
[ApiController]
[Route("/Api")]
public class AdminController : BaseController
{
    public AdminController(INotification notification) : base(notification)
    {
    }

    [Route("/Oi")]
    [HttpGet]
    public async Task<IActionResult> PrintOi()
    {
        return Ok("oi");
    }
}