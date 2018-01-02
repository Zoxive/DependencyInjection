namespace App
{

public interface IKeystoneAdminDatabase {}

public class Database : IKeystoneAdminDatabase
{
	public Database
	(
		IDataSource dataSource,
		IConnectionFactory connectionFactory
	)
	{
	}
}

}
