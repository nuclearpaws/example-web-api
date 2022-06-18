using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApi.WebApi.Controllers;

[ApiController]
[Route("")]
public class _RootController
    : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return RedirectToAction(null, "Example");
    }
}
