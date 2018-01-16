using System.Collections.Generic;
using System;

namespace App
{
    public interface IEntityActionsFactory
    {
        IEnumerable<IEntityAction> GetEntityActions();
    }

    public class EntityActionsFactory : IEntityActionsFactory
    {
        private readonly IEnumerable<IEntityAction> _baseEntityActions;

        public EntityActionsFactory
        (
            IEnumerable<IEntityAction> baseEntityActions,
            Lazy<ReadRoot> readRoot,
            Lazy<RootRulesetEntityAction> customRootAction
        )
        {
            _baseEntityActions = baseEntityActions;
        }

        public IEnumerable<IEntityAction> GetEntityActions()
        {
            return _baseEntityActions;
        }
    }

}
