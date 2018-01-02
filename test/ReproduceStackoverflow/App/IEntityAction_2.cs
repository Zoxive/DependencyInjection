namespace App
{

public class Create : IEntityAction
{
	public Create
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		SetDefaultValuesStep setDefaultValuesStep,
		ApplyAssignmentsStep applyAssignmentsStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		CreateStep createStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
