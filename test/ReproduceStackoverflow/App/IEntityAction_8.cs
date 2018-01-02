﻿namespace App
{

public class RulesetEntityAction : IEntityAction
{
	public RulesetEntityAction
	(
		IEntityActionDelegator entityActionDelegator,
		IRulesetExecutionContextFactory rulesetExecutionContextFactory,
		IEntityHookpointStepFactory hookpointStepFactory,
		IReadStep readStep,
		ApplyNonPersistedFieldValuesStep applyNonPersistedFieldValuesStep,
		CopyCurrentRecordToOriginalRecordStep copyCurrentRecordToOriginalRecordStep,
		ApplyAssignmentsStep applyAssignmentsStep,
		ApplyAuthorizationStep applyAuthorizationStep,
		AddMetadataStep addMetadataStep,
		ValidateStep validateStep,
		ExitOnErrorStep exitOnErrorStep,
		ISaveStep saveStep,
		ReadAllStep readAllStep,
		ValidateAllStep validateAllStep,
		ISaveAllStep saveAllStep
	)
	{
	}
}

}
