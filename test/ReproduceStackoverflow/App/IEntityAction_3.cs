namespace App
{

public class Delete : IEntityAction
{
	public Delete
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		IReadStep readStep,
		CopyCurrentRecordToOriginalRecordStep copyCurrentRecordToOriginalRecordStep,
		AddMetadataStep addMetadataStep,
		RestrictDeleteStep restrictDeleteStep,
		DeleteStep deleteStep
	)
	{
	}
}

}
