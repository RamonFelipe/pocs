using CorrelationApi.Configurations.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorrelationApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ICorrelationIdGenerator _correlationIdGenerator;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
        ICorrelationIdGenerator correlationIdGenerator,
        ILogger<WeatherForecastController> logger)
    {
        _correlationIdGenerator = correlationIdGenerator;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("CorrelationId {correlationId}: Processing weather forecast request",
            _correlationIdGenerator.Get());

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
