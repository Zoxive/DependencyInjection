namespace App
{

public class ReadRoot
{
	public ReadRoot
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		ReadRootStep readRootStep,
		OnLoginSystemHookpointStep onLoginSystemHookpointStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
