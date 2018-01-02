namespace App
{

public interface IManyToManyEntityRecordServiceImpl {}

public class ManyToManyEntityRecordServiceImpl : IManyToManyEntityRecordServiceImpl
{
	public ManyToManyEntityRecordServiceImpl
	(
		IEntityRecordServiceImpl entityRecordServiceImpl,
		IManyToManyRecordUpdateService recordUpdateService
	)
	{
	}
}

}
