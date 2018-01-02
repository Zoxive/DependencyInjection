namespace App
{

public interface IEntityHookpointStepFactory {}

public class EntityHookpointStepFactory : IEntityHookpointStepFactory
{
	public EntityHookpointStepFactory
	(
		IGenericEngineFactory<EntityActionHook,IGenericExpressionValueLookup> genericEngineFactory,
		IHookpointExecutionService hookpointExecutionService,
		IRuleEngineExceptionMessageFactory ruleEngineExceptionMessageFactory
	)
	{
	}
}

    public interface IGenericExpressionValueLookup
    {
    }

    public class GenericExpressionValueLookup : IGenericExpressionValueLookup 
    {
    }

    public class EntityActionHook
    {
    }

}
