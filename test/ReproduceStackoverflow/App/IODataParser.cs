namespace App
{

public interface IODataParser {}

public class ODataPocoSqlParser : IODataParser
{
	public ODataPocoSqlParser
	(
		IKeystoneApplicationDatabase database,
		IEntityDatabaseDefinitionFactory factory,
		IEntityDefinitionRepository entityDefinitionRepository,
		IODataLogicalOperatorSqlParser logicalOperatorSqlParser
	)
	{
	}
}

}
