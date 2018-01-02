namespace App
{

public interface IEntityRecordRepository {}

public class EntityRecordRepository : IEntityRecordRepository
{
	public EntityRecordRepository
	(
		IEntityRecordDao entityRecordDao,
		IEntityRecordFactory entityRecordFactory,
		IEntityDefinitionRepository entityDefinitionRepository,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository
	)
	{
	}
}

}
