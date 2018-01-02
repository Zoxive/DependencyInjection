namespace App
{

public interface IUsageMetricsService {}

public class UsageMetricsService : IUsageMetricsService
{
	public UsageMetricsService
	(
		IUsageMetricsRepository usageMetricsRepository
	)
	{
	}
}

}
