namespace App
{

public class UsageMetricsDelegatingHandler
{
	public UsageMetricsDelegatingHandler
	(
		IUsageMetricsService usageMetricsService,
		IUsageMetricsRuleEventAggregator usageMetricRuleEventAggregator,
		IUsageMetricsRecordCrudCounterSerializer usageMetricsRecordCrudCounterSerializer,
		IEntityActionEventAggregator entityActionEventAggregator,
		KeystoneApplication keystoneApplication,
		ICurrentUser currentUser
	)
	{
	}
}

}
