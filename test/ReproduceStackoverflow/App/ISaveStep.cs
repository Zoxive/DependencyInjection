namespace App
{

public interface ISaveStep {}

public class SaveStep : ISaveStep
{
	public SaveStep
	(
		IAuthorizedEntityRecordService entityRecordService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository,
		IRecordAssignmentsService recordAssignmentsService
	)
	{
	}
}

}
