namespace ProjectBasedLearning.RazorLib.WeatherForecasts;

public class WeatherForecast : IWeatherForecast
{
	public WeatherForecast(
		DateOnly date,
		int temperatureC,
		string? summary)
	{
		Date = date;
		TemperatureC = temperatureC;
		Summary = summary;
	}

    public DateOnly Date { get; }
    public int TemperatureC { get; }
    public string? Summary { get; }
    
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
