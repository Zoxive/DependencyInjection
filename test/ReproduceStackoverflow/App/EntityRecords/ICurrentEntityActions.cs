using System.Collections.Generic;
using System.Linq;

namespace ReproduceStackoverflow.App.EntityRecords
{
    public interface ICurrentEntityActions
    {
    }

    internal struct CurrentEntityActions : ICurrentEntityActions 
    {
        private readonly IReadOnlyCollection<IEntityAction> _entityActions;

        internal CurrentEntityActions(IEnumerable<IEntityAction> entityActions)
        {
            _entityActions = entityActions.ToList();
        }

        public IEnumerable<IEntityAction> Value => _entityActions;
    }

    public interface IEntityAction
    {
    }

    public class Copy : IEntityAction
    {
        public Copy
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
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

    public class Create : IEntityAction
    {
        public Create
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
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

    public class Delete : IEntityAction
    {
        public Delete
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
            IReadStep readStep,
            CopyCurrentRecordToOriginalRecordStep copyCurrentRecordToOriginalRecordStep,
            AddMetadataStep addMetadataStep,
            RestrictDeleteStep restrictDeleteStep,
            DeleteStep deleteStep
        )
        {
        }
    }

    public class Read : IEntityAction 
    {
        public Read
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
            IReadStep readStep,
            ValidateStep validateStep,
            ExitOnErrorStep exitOnErrorStep,
            AddMetadataStep addMetadataStep,
            ApplyAuthorizationStep applyAuthorizationStep
        )
        {
        }
    }

    public class ReadAll : IEntityAction
    {
        public ReadAll
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Stepes
            ReadAllStep readAllStep,
            AddMetadataStep addMetadataStep,
            ApplyAuthorizationStep applyAuthorizationStep
        )
        {
        }
    }

    public class ReadAncestors : IEntityAction
    {
        public ReadAncestors
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
            ReadAncestorsStep readAncestorsStep,
            AddMetadataStep addMetadataStep,
            ApplyAuthorizationStep applyAuthorizationStep
        )
        {
        }
    }

    public class Update : IEntityAction
    {
        public Update
        (
            IEntityActionDelegator entityActionDelegator,
            IRulesetExecutionContextFactory rulesetExecutionContextFactory,
            IEntityHookpointStepFactory hookpointStepFactory,

            // Steps
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
}