using System.Collections.Generic;
using System.Linq;

namespace ReproduceStackoverflow.App
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
    }
}