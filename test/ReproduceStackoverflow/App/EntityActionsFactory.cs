using System.Collections.Generic;
using System;

namespace App
{

    public class EntityActionsFactory
    {
        private readonly IEnumerable<IEntityAction> _baseEntityActions;

        public EntityActionsFactory
        (
            ICurrentEntityDefinitionAccessor currentEntityDefinitionAccessor,
            IEnumerable<IEntityAction> baseEntityActions,
            Lazy<ReadRoot> readRoot,
            Lazy<RootRulesetEntityAction> customRootAction
        )
        {
            _baseEntityActions = baseEntityActions;
        }

        public ICurrentEntityActions GetEntityActions()
        {
            return new CurrentEntityActions(_baseEntityActions);
        }
    }

}
