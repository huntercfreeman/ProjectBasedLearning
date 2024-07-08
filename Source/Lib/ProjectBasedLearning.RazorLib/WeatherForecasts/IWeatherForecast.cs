namespace ProjectBasedLearning.RazorLib.WeatherForecasts;

public interface IWeatherForecast
{
    public DateOnly Date { get; }
    public int TemperatureC { get; }
    public int TemperatureF { get; }
    public string? Summary { get; }
}
