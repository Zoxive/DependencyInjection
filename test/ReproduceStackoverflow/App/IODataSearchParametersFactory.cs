namespace App
{

public interface IODataSearchParametersFactory {}

public class ODataSearchParametersFactory : IODataSearchParametersFactory
{
	public ODataSearchParametersFactory
	(
		IEntityDatabaseDefinitionFactory entityDatabaseDefinitionFactory
	)
	{
	}
}

}
