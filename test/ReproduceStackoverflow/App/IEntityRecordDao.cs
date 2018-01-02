namespace App
{

public interface IEntityRecordDao {}

public class CachedEntityRecordDao : IEntityRecordDao
{
	public CachedEntityRecordDao
	(
		IEntityRecordDao dao,
		IEntityRecordCache entityRecordCache
	)
	{
	}
}

}
