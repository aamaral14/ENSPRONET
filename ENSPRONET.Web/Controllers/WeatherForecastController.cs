using ENSPRONET.Services.Services.Country;
using Microsoft.AspNetCore.Mvc;

namespace ENSPRONET.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ICountryReadService countryReadService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, ICountryReadService countryReadService)
    {
        _logger = logger;
        this.countryReadService = countryReadService;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        var t = await countryReadService.List();


        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
