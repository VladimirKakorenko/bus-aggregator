using Microsoft.AspNetCore.Mvc;

namespace Adapter.API.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet("/data")]
    public string GetData()
    {
        return "Hello from Adapter Service!";
    }
}