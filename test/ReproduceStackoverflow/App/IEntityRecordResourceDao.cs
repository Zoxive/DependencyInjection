namespace App
{

public interface IEntityRecordResourceDao {}

public class EntityRecordResourceDao : IEntityRecordResourceDao
{
	public EntityRecordResourceDao
	(
		IKeystoneApplicationDatabase database,
		IEntityRecordCache entityRecordCache,
		IEntityDatabaseDefinitionFactory definitionFactory,
		IEntityRecordQueryBuilderFactory entityRecordQueryBuilderFactory
	)
	{
	}
}

}
