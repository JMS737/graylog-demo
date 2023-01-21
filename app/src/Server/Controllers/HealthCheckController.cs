
using Microsoft.AspNetCore.Mvc;

namespace webapp.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController
{
    [HttpGet]
    public string Get()
    {
        return "Ok";
    }
}