namespace App
{

public interface IEntityRecordReadAncestorsService {}

public class EntityRecordReadAncestorsService : IEntityRecordReadAncestorsService
{
	public EntityRecordReadAncestorsService
	(
		IAuthorizedEntityRecordService entityRecordService
	)
	{
	}
}

}
