namespace App
{

public interface IKeystoneApplicationDatabase {}

public class ApplicationDatabase : IKeystoneApplicationDatabase
{
	public ApplicationDatabase
	(
		IDataSource dataSource,
		IConnectionFactory connectionFactory
	)
	{
	}
}

}
