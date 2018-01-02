namespace App
{

public interface IEntityRecordResourceRepository {}

public class EntityRecordResourceRepository : IEntityRecordResourceRepository
{
	public EntityRecordResourceRepository
	(
		IEntityRecordResourceDao entityRecordResourceDao,
		ILocaleDao localeDao
	)
	{
	}
}

}
