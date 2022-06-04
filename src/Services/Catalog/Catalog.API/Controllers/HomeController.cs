using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [Route("/data")]
    public string GetData()
    {
        return "Hello from Catalog Controller!";
    }
}