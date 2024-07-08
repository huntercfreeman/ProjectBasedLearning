using ProjectBasedLearning.RazorLib.WeatherForecasts;

namespace ProjectBasedLearning.RazorLib.Installations;

public class ProjectBasedLearningRazorLibConfigBuilder : IProjectBasedLearningRazorLibConfig
{
	private readonly object _buildLock = new();

	private ProjectBasedLearningRazorLibConfig? _projectBasedLearningRazorLibConfig;
	
	public Func<IServiceProvider, IWeatherForecastService> WeatherForecastServiceFunc { get; set; }
	
	public IWeatherForecastService WeatherForecastService => _projectBasedLearningRazorLibConfig is null
		? throw new ApplicationException($"Invoke {Build} to initialize the {nameof(ProjectBasedLearningRazorLibConfigBuilder)}")
		: _projectBasedLearningRazorLibConfig.WeatherForecastService;
	
	public ProjectBasedLearningRazorLibConfig Build(IServiceProvider serviceProvider)
	{
		// Optimization check
		// 	(avoid the lock)
		if (_projectBasedLearningRazorLibConfig is null)
		{
			lock (_buildLock)
			{
				// Race condition check
				// 	(someone was in this lock, and not finished, when I checked for null)
				if (_projectBasedLearningRazorLibConfig is null)
				{
					if (WeatherForecastServiceFunc is null)
						throw new ApplicationException($"{nameof(WeatherForecastServiceFunc)} was null.");
			
					_projectBasedLearningRazorLibConfig = new ProjectBasedLearningRazorLibConfig(
						WeatherForecastServiceFunc.Invoke(serviceProvider));
				}
			}
		}
		
		return _projectBasedLearningRazorLibConfig;
	}
}
