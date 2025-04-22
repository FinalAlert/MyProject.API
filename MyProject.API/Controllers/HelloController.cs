using Microsoft.AspNetCore.Mvc;

namespace MyProject.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello from API!";
}
