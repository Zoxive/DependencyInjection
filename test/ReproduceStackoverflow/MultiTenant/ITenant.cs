namespace ReproduceStackoverflow.App.MultiTenant
{
    public interface ITenant
    {
        string Id { get; }
    }

    public class Tenant : ITenant
    {
        public Tenant(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}