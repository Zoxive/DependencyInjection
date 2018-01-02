namespace App
{

public interface IEntityDatabaseDefinitionFactory {}

public class SecureEntityDatabaseDefinitionFactory : IEntityDatabaseDefinitionFactory
{
	public SecureEntityDatabaseDefinitionFactory
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
