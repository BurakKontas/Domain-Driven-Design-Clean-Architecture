using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DDDAPI.Api.Controllers;

public class ErrorsController : ControllerBase
{

    [Route("/error")]
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        if (exception is null) return Problem();
        return Problem(title: exception.Message);
    }

}