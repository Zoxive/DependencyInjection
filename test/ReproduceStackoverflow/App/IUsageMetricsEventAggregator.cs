namespace App
{

public interface IUsageMetricsEventAggregator {}

public class UsageMetricsEventAggregator : IUsageMetricsEventAggregator
{
	public UsageMetricsEventAggregator
	(
		IUsageMetricsRuleEventAggregator usageMetricsRuleEventAggregator,
		IEntityActionEventAggregator entityActionEventAggregator
	)
	{
	}
}

}
