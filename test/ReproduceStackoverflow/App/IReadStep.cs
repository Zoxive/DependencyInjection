namespace App
{

public interface IReadStep {}

public class ReadStep : IReadStep
{
	public ReadStep
	(
		IAuthorizedEntityRecordService entityRecordService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository
	)
	{
	}
}

}
