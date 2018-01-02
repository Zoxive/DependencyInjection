namespace App
{

public interface IEntityRecordServiceImpl {}

public class EntityRecordServiceImpl : IEntityRecordServiceImpl
{
	public EntityRecordServiceImpl
	(
		IEntityRecordRepository entityRecordRepository,
		IEntityRecordNotificationHandler entityRecordNotificationHandler,
		IEntityRecordContentService entityRecordContentService,
		IEntityRecordResourceService entityRecordResourceService,
		IEntityRecordSequenceFieldService entityRecordSequenceFieldService,
		IRecordAssignmentsService recordAssignmentsService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository
	)
	{
	}
}

}
