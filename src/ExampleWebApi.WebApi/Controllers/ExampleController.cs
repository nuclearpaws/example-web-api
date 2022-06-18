using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExampleController
    : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        var response = "Hello World!";
        return Ok(response);
    }
}
