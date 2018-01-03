using System.Collections.Generic;
using System;

namespace App
{

    public class EntityActionsFactory
    {
        private readonly ICurrentEntityDefinitionAccessor _currentEntityDefinitionAccessor;
        private readonly IEnumerable<IEntityAction> _baseEntityActions;
        private readonly Lazy<ReadRoot> _readRoot;
        private readonly Lazy<RootRulesetEntityAction> _customRootAction;

        public EntityActionsFactory
        (
            ICurrentEntityDefinitionAccessor currentEntityDefinitionAccessor,
            IEnumerable<IEntityAction> baseEntityActions,
            Lazy<ReadRoot> readRoot,
            Lazy<RootRulesetEntityAction> customRootAction
        )
        {
            _currentEntityDefinitionAccessor = currentEntityDefinitionAccessor;
            _baseEntityActions = baseEntityActions;
            _readRoot = readRoot;
            _customRootAction = customRootAction;
        }

        public ICurrentEntityActions GetEntityActions()
        {
            /*
            var isRootEntity = _currentEntityDefinitionAccessor.Value.Name == BaseEntityDefinition.RootName;
            if (isRootEntity)
            {
                var readRoot = _readRoot.Value;
                var customRootAction = _customRootAction.Value;

                var rootActions = _baseEntityActions.ToDictionary(x => x.Action);
                rootActions[readRoot.Action] = readRoot;
                rootActions[customRootAction.Action] = customRootAction;
                return new CurrentEntityActions(rootActions.Values);
            }
            */

            return new CurrentEntityActions(_baseEntityActions);
        }
    }

}
