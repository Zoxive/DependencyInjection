namespace App
{

public class UpdateResource
{
	public UpdateResource
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		IReadStep readStep,
		ApplyNonPersistedFieldValuesStep applyNonPersistedFieldValuesStep,
		CopyCurrentRecordToOriginalRecordStep copyCurrentRecordToOriginalRecordStep,
		ApplyAssignmentsStep applyAssignmentsStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		IUpdateStep updateStep,
		AddMetadataStep addMetadataStep,
		ApplyAuthorizationStep applyAuthorizationStep,
		UpdateResourceStep updateResourceStep,
		ApplyResourceAssignmentsStep applyResourceAssignmentsStep
	)
	{
	}
}

}
