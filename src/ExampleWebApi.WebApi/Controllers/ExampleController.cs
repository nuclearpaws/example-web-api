using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExampleController
    : ControllerBase
{
    [HttpGet]
    [Route("")]
    public ActionResult<string> Get()
    {
        var response = "Hello World!";
        return Ok(response);
    }

    [HttpGet]
    [Route("greeting")]
    public ActionResult<string> GetGreeting(
        [FromQuery] string name)
    {
        var response = $"Greetings {name}!";
        return Ok(response);
    }

    [HttpGet]
    [Route("farewell")]
    public ActionResult<string> GetFarewell(
        [FromQuery] string name)
    {
        var response = $"Farewell {name}!";
        return Ok(response);
    }
}
