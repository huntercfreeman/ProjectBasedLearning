using ProjectBasedLearning.RazorLib.WeatherForecasts;

namespace ProjectBasedLearning.ServerSide.Data;

public class WeatherForecastService : IWeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<IWeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        return Task.FromResult(
        	Enumerable.Range(1, 5)
        	.Select(index => (IWeatherForecast)new WeatherForecast(
	        	startDate.AddDays(index),
				Random.Shared.Next(-20, 55),
				"abc123" + Summaries[Random.Shared.Next(Summaries.Length)]))
			.ToArray());
    }
}
