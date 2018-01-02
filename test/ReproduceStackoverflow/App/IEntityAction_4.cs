namespace App
{

public class Read : IEntityAction
{
	public Read
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		IReadStep readStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
