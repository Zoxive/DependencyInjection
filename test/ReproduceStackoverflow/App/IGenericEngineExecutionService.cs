namespace App
{

public interface IGenericEngineExecutionService {}

public class GenericEngineExecutionService : IGenericEngineExecutionService
{
	public GenericEngineExecutionService
	(
		ITracingRuleExecutingAggregateService tracingRuleExecutingAggregateService,
		IGenericEngineSettingsService genericEngineSettingsService
	)
	{
	}
}

}
