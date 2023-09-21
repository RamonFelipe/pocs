using Microsoft.AspNetCore.Mvc;

namespace Versioning.Controllers.v2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get() => ".Net Web API Version 2";
}
