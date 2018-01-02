using Microsoft.AspNetCore.Http;

namespace ReproduceStackoverflow.App
{
    public interface IKeystoneEntityNameResolver
    {
    }

    public class KeystoneEntityNameResolver : IKeystoneEntityNameResolver
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public KeystoneEntityNameResolver(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}