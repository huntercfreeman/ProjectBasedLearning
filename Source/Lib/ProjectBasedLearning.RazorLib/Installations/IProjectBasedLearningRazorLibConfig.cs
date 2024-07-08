using ProjectBasedLearning.RazorLib.WeatherForecasts;

namespace ProjectBasedLearning.RazorLib.Installations;

public interface IProjectBasedLearningRazorLibConfig
{
	public IWeatherForecastService WeatherForecastService { get; }
}
