namespace App
{

public interface IEntityRecordReadAllService {}

public class EntityRecordReadAllService : IEntityRecordReadAllService
{
	public EntityRecordReadAllService
	(
		IAuthorizedEntityRecordService entityRecordService
	)
	{
	}
}

}
