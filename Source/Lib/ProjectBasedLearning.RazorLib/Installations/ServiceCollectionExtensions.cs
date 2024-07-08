using Microsoft.Extensions.DependencyInjection;
using ProjectBasedLearning.RazorLib.WeatherForecasts;

namespace ProjectBasedLearning.RazorLib.Installations;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddProjectBasedLearningRazorLibServices(
		this IServiceCollection services,
		Action<ProjectBasedLearningRazorLibConfigBuilder>? configureAction = null)
	{
		var projectBasedLearningRazorLibConfigBuilder = new ProjectBasedLearningRazorLibConfigBuilder();
	
		if (configureAction is not null)
			configureAction.Invoke(projectBasedLearningRazorLibConfigBuilder);
		
		return services.AddSingleton<IWeatherForecastService>(serviceProvider =>
			projectBasedLearningRazorLibConfigBuilder.Build(serviceProvider).WeatherForecastService);
	}
}


