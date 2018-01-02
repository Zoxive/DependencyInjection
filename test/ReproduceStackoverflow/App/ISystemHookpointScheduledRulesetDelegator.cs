namespace App
{

public interface ISystemHookpointScheduledRulesetDelegator {}

public class SystemHookpointScheduledRulesetDelegator : ISystemHookpointScheduledRulesetDelegator
{
	public SystemHookpointScheduledRulesetDelegator
	(
		IHookpointExecutionService hookpointExecutionService,
		IEntityActionEventAggregator entityActionEventAggregator,
		TraceDelegatingHandler traceDelegatingHandler,
		ResilientRecordsDelegatingHandler resilientRecordsDelegatingHandler,
		UsageMetricsDelegatingHandler usageMetricsDelegatingHandler
	)
	{
	}
}

}
