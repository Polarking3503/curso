using Microsoft.AspNetCore.Mvc;
using myFirstApi.Models;

namespace myFirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController
{
    private static readonly string[] summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};
    [HttpGet]
    public IEnumerable<WeatherForeCast> Get()
    {
        return Enumerable.Range(1, 5).Select(index =>
       new WeatherForeCast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
    }
}
