using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UZUSIS.Application;
using UZUSIS.Core.ViewModel;

namespace UZUSIS.API.Controllers;
[ApiController]

public abstract class BaseController : ControllerBase
{
    private readonly INotification _notification;

    protected BaseController(INotification notification)
    {
        _notification = notification;
    }


    protected ActionResult CustomResponse(object? result = null)
    {
        if (ValidOperation)
        {
            return Ok(new ResultViewModel()
            {
                Message = "Result request",
                Success = true,
                Data = result!
            });
        }

        if (_notification.notFound)
        {
            return NotFound();
        }

        return BadRequest(
            error: new ResultViewModel()
            {
                Message = "Result request unsuccessfully",
                Success = false,
                Data = _notification.GetNotifications().ToList()
            }
        );

    }


    private bool ValidOperation => !(_notification.hasNotification() || _notification.notFound);

}