namespace App
{

public interface IEntityRecordSequenceFieldService {}

public class EntityRecordSequenceFieldService : IEntityRecordSequenceFieldService
{
	public EntityRecordSequenceFieldService
	(
		IEntityRecordRepository entityRecordRepository,
		IEntityRecordNotificationHandler entityRecordNotificationHandler
	)
	{
	}
}

}
