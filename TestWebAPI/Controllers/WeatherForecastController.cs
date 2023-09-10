using Microsoft.AspNetCore.Mvc;
using WebApiModel;

namespace TestWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet]
    [Route("summaries/{index}")]
    public string GetSummaries(int index)
    {
        return Summaries[index];
    }

    [HttpPost]
    [Route("save")]
    public void SaveForecast(WeatherForecast weatherForecast)
    {
        RecordsHolder.AddForecast(weatherForecast);
    }

    //private readonly ILogger<WeatherForecastController> _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast[] Get()
    {
        var list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        foreach (var forecast in list)
        {
            if (RecordsHolder.Max == null || forecast.TemperatureC >= RecordsHolder.Max.TemperatureC)
            {
                RecordsHolder.Max = forecast;
            }

            if (RecordsHolder.Min == null || forecast.TemperatureC <= RecordsHolder.Min.TemperatureC)
            {
                RecordsHolder.Min = forecast;
            }
        }

        return list;
    }

    [HttpGet]
    [Route("max")]
    public ObjectResult Max()
    {
        if (RecordsHolder.Max == null)
        {
            return BadRequest("Max is null");
        }

        return Ok(RecordsHolder.Max);
    }

    [HttpGet]
    [Route("min")]
    public ObjectResult Min()
    {
        if (RecordsHolder.Min == null)
        {
            return BadRequest("Min is null");
        }

        return Ok(RecordsHolder.Min);
    }
}