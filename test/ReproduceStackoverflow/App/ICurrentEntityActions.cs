using System.Collections.Generic;

namespace App
{

public interface ICurrentEntityActions {}

    public class CurrentEntityActions : ICurrentEntityActions
    {
        private readonly IEnumerable<IEntityAction> _baseEntityActions;

        public CurrentEntityActions(IEnumerable<IEntityAction> baseEntityActions)
        {
            _baseEntityActions = baseEntityActions;
        }
    }

}
