using Microsoft.AspNetCore.Mvc;

namespace Data.API.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [Route("/data")]
    public string GetData()
    {
        return "Hello from Data Controller!";
    }
}