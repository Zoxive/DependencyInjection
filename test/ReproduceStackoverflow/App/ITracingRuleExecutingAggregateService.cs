namespace App
{

public interface ITracingRuleExecutingAggregateService {}

public class TracingRuleExecutingAggregateService : ITracingRuleExecutingAggregateService
{
	public TracingRuleExecutingAggregateService
	(
		ITraceSettingsRepository traceSettings,
		IEntityActionEventAggregator eventAggregator,
		ITraceExpressionEventFactory traceExpressionEventFactory
	)
	{
	}
}

}
