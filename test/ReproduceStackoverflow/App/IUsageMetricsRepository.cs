namespace App
{

public interface IUsageMetricsRepository {}

public class UsageMetricsRepository : IUsageMetricsRepository
{
	public UsageMetricsRepository
	(
		IKeystoneUnitOfWorkFactory keystoneUnitOfWorkFactory,
		IUsageMetricsFactory usageMetricsFactory,
		IUsageMetricsDao usageMetricsDao
	)
	{
	}
}

}
