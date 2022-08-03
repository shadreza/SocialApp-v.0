namespace API;

public class WeatherForecast
{
    public System.DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    // turning into dotnet 5 the classicals
    // public string? Summary { get; set; }
    public string Summary { get; set; }
}
