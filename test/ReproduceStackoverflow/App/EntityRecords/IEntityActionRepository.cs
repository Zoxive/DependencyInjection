using ReproduceStackoverflow.App.MultiTenant;

namespace ReproduceStackoverflow.App
{
    public interface IEntityActionRepository
    {
    }

    public class EntityActionRepository : IEntityActionRepository
    {
        public EntityActionRepository
        (
            ICurrentEntityActions currentEntityActions,
            IAuthorizedService authorizedService
        )
        {
            
        }
    }

    public interface IAuthorizedService
    {
    }

    public class AuthorizedService : IAuthorizedService
    {
        private readonly ITenant _tenant;
        private readonly ICurrentUser _currentUser;

        public AuthorizedService(ITenant tenant, ICurrentUser currentUser)
        {
            _tenant = tenant;
            _currentUser = currentUser;
        }
    }
}