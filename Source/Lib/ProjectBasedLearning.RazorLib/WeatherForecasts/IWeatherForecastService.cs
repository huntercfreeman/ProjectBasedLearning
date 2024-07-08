namespace ProjectBasedLearning.RazorLib.WeatherForecasts;

public interface IWeatherForecastService
{
	public Task<IWeatherForecast[]> GetForecastAsync(DateOnly startDate);
}
