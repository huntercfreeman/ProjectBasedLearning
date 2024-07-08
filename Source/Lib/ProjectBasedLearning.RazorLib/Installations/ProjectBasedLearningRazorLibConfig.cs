using ProjectBasedLearning.RazorLib.WeatherForecasts;

namespace ProjectBasedLearning.RazorLib.Installations;

public record ProjectBasedLearningRazorLibConfig(
		IWeatherForecastService WeatherForecastService)
	: IProjectBasedLearningRazorLibConfig;
