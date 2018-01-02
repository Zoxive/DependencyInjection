namespace App
{

public interface IEntityRecordManyToManyQueryBuilder {}

public class EntityRecordManyToManyQueryBuilder : IEntityRecordManyToManyQueryBuilder
{
	public EntityRecordManyToManyQueryBuilder
	(
		IEntityRecordQueryBuilder entityRecordQueryBuilder,
		IManyToManySelectBuilder manyToManySelectBuilder,
		IODataQueryBuilder oDataQueryBuilder
	)
	{
	}
}

}
