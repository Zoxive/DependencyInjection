namespace App
{

public interface IODataQueryBuilder {}

public class ODataQueryBuilder : IODataQueryBuilder
{
	public ODataQueryBuilder
	(
		IODataParser oDataParser,
		IEntityDefinitionRepository entityDefinitionRepository,
		IEntityDatabaseDefinitionFactory entityDatabaseDefinitionFactory
	)
	{
	}
}

}
