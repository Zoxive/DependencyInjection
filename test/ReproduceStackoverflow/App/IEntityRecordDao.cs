namespace App
{

public interface IEntityRecordDao {}

public class EntityRecordDao : IEntityRecordDao
{
	public EntityRecordDao
	(
        IKeystoneApplicationDatabase database,
        IEntityDefinitionRepository entityDefinitionRepository,
        IEntityDatabaseDefinitionFactory definitionFactory,
        IODataParser parser,
        IEntityRecordDtoFactory entityRecordDtoFactory,
        IEntityRecordQueryBuilderFactory entityRecordQueryBuilderFactoryFactory, 
        EntityDatabaseDefinitionFactory unsecureDefinitionFactory
	)
	{
	}
}

    public class EntityDatabaseDefinitionFactory : IEntityDatabaseDefinitionFactory
    {
        public EntityDatabaseDefinitionFactory(IKeystoneApplicationDatabase keystoneApplicationDatabase)
        {
            
        }
    }

    public interface IEntityRecordDtoFactory
    {
    }

    public class EntityRecordDtoFactory : IEntityRecordDtoFactory
    {
    }
}
