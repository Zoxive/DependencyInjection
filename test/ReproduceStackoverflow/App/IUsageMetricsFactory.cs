namespace App
{

public interface IUsageMetricsFactory {}

public class UsageMetricsFactory : IUsageMetricsFactory
{
	public UsageMetricsFactory
	(
		KeystoneApplication keystoneApplication,
		ICurrentUser currentUser,
		IUsageMetricsEventAggregator usageMetricsEventAggregator,
		IUsageMetricsRecordCrudCounterSerializer usageMetricsRecordCrudCounterSerializer
	)
	{
	}
}

}
