namespace App
{

public interface IEntityRecordQueryBuilderFactory {}

public class EntityRecordQueryBuilderFactory : IEntityRecordQueryBuilderFactory
{
	public EntityRecordQueryBuilderFactory
	(
		IEntityRecordQueryBuilder entityRecordQueryBuilder,
		IEntityRecordManyToManyQueryBuilder entityRecordManyToManyQueryBuilder
	)
	{
	}
}

}
