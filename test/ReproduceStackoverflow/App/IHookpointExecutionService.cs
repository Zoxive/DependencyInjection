namespace App
{

public interface IHookpointExecutionService {}

public class HookpointExecutionService : IHookpointExecutionService
{
	public HookpointExecutionService
	(
		IGenericEngineExecutionService genericEngineExecutionService,
		IEntityActionEventAggregator eventAggregator,
		IHookpointExecuteEventFactory hookpointExecuteEventFactory
	)
	{
	}
}

}
