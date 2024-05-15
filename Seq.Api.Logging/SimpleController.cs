using Microsoft.AspNetCore.Mvc;

namespace Seq.Api.Logging;

[ApiController]
[Route("/hello")]
public class SimpleController : ControllerBase
{
    private readonly ILogger<SimpleController> _log;

    public SimpleController(ILogger<SimpleController> log)
    {
        _log = log;
    }

    [HttpGet]
    public async Task<IActionResult> SayHello()
    {
        _log.LogInformation("hello");
        return Ok();
    }
}