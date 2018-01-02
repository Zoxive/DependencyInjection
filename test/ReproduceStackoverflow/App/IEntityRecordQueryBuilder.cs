namespace App
{

public interface IEntityRecordQueryBuilder {}

public class EntityRecordQueryBuilder : IEntityRecordQueryBuilder
{
	public EntityRecordQueryBuilder
	(
		IKeystoneApplicationDatabase database,
		IODataQueryBuilder oDataQueryBuilder
	)
	{
	}
}

}
