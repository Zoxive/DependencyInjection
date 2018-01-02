namespace App
{

public interface IEntityAction {}

public class Copy : IEntityAction
{
	public Copy
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		IReadStep readStep,
		CopyCurrentRecordToOriginalRecordStep copyCurrentRecordToOriginalRecordStep,
		AddMetadataStep addMetadataStep,
		ClearOrDefaultUniqueValuesStep clearOrDefaultUniqueValuesStep,
		SetDefaultValuesStep setDefaultValuesStep,
		ApplyAssignmentsStep applyAssignmentsStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		CopyStep copyStep,
		ApplyAuthorizationStep applyAuthorizationStep
	)
	{
	}
}

}
