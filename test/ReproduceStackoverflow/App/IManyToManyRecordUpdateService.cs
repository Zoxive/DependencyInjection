namespace App
{

public interface IManyToManyRecordUpdateService {}

public class ManyToManyRecordUpdateService : IManyToManyRecordUpdateService
{
	public ManyToManyRecordUpdateService
	(
		IManyToManyRecordValidationService validationService,
		IEntityRecordServiceImpl entityRecordServiceImpl
	)
	{
	}
}

}
