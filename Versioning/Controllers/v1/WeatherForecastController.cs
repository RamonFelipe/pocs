using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get() => ".Net Web API Version 1";
}
