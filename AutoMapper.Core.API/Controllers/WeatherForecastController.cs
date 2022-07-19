using AutoMapper.Core.API.Interfaces;
using AutoMapper.Core.API.Models;
using AutoMapper.Core.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Core.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMapperService _mapperService;


    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapperService mapperService)
    {
        _logger = logger;
        _mapperService = mapperService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    public IActionResult GetMockResponse()
    {
        CalendarEventForm response = _mapperService.GetTransformedModel();
        return Ok(response);
    }

    public string GetMockResponseString()
    {
        var response = _mapperService.GetTransformedModelString();
        return response;
    }

}
