using ReproduceStackoverflow.App.MultiTenant;

namespace ReproduceStackoverflow.App
{
    public class CurrentUser : ICurrentUser
    {
        private readonly ITenant _tenant;

        public CurrentUser(ITenant tenant)
        {
            _tenant = tenant;
        }
    }

    public interface ICurrentUser
    {
    }
}