using System.Collections.Generic;
using System;

namespace App
{

    public class EntityActionsFactory
    {
        public EntityActionsFactory
        (
            ICurrentEntityDefinitionAccessor currentEntityDefinitionAccessor,
            IEnumerable<IEntityAction> baseEntityActions,
            Lazy<ReadRoot> readRoot,
            Lazy<RootRulesetEntityAction> customRootAction
        )
        {
        }
    }

}
