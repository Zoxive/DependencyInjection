namespace App
{

public interface IManyToManyRecordValidationService {}

public class ManyToManyRecordValidationService : IManyToManyRecordValidationService
{
	public ManyToManyRecordValidationService
	(
		IEntityRecordRepository entityRecordRepository
	)
	{
	}
}

}
