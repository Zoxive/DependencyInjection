namespace App
{

public interface IEntityActionDelegator {}

public class EntityActionDelegator : IEntityActionDelegator
{
	public EntityActionDelegator
	(
		IEntityActionEventAggregator eventAggregator,
		IEntityActionStepProcessor entityActionStepProcessor,
		SaveChangedUserDelegatingHandler saveChangedUserDelegatingHandler,
		TraceDelegatingHandler traceDelegatingHandler,
		HookpointErrorDelegatingHandler hookpointErrorDelegatingHandler,
		UsageMetricsDelegatingHandler usageMetricsDelegatingHandler
	)
	{
	}
}

}
