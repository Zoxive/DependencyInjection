namespace App
{

public interface ISystemHookpointExecutionService {}

public class SystemHookpointExecutionService : ISystemHookpointExecutionService
{
	public SystemHookpointExecutionService
	(
		ISystemHookpointRepository systemHookpointRepository,
		ISystemHookpointScheduledRulesetDelegator hookpointExecutionService,
		IGenericEngineFactory<SystemHookpoint,IGenericExpressionValueLookup> genericEngineFactory,
		IExceptionDetailRepository exceptionDetailRepository,
		IRuleEngineExceptionMessageFactory ruleEngineExceptionMessageFactory
	)
	{
	}
}

    public class SystemHookpoint
    {
    }
}
