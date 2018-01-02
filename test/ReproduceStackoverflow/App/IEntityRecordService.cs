namespace App
{

public interface IEntityRecordService {}

public class EntityRecordService : IEntityRecordService
{
	public EntityRecordService
	(
		IEntityRecordServiceImplFactory entityRecordServiceImplFactory
	)
	{
	}
}

}
