namespace App
{

public class ReadAll : IEntityAction
{
	public ReadAll
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		ReadAllStep readAllStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
