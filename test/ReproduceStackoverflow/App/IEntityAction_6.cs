namespace App
{

public class ReadAncestors : IEntityAction
{
	public ReadAncestors
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		ReadAncestorsStep readAncestorsStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
