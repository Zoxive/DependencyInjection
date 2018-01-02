namespace ReproduceStackoverflow.App.EntityRecords
{
    public interface IKeystoneApplicationDatabase
    {
    }

    public class KeystoneApplicationDatabase : IKeystoneApplicationDatabase
    {
        private readonly IDataSource _dataSource;
        private readonly IConnectionFactory _connectionFactory;

        public KeystoneApplicationDatabase(IDataSource dataSource, IConnectionFactory connectionFactory)
        {
            _dataSource = dataSource;
            _connectionFactory = connectionFactory;
        }
    }

    public interface IConnectionFactory
    {
    }

    public class ConnectionFactory : IConnectionFactory
    {
        private readonly ICurrentUser _currentUser;

        public ConnectionFactory(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }
    }
   

    public interface IDataSource
    {
    }

    public class DataSource : IDataSource
    {
    }
}