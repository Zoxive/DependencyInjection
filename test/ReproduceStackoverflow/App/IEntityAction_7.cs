namespace App
{

public class Update : IEntityAction
{
	public Update
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
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
