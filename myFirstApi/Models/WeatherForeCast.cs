namespace myFirstApi.Models;

public class WeatherForeCast
{
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public WeatherForeCast(DateOnly date, int temperatureC, string summary)
    {
        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
    }

}
