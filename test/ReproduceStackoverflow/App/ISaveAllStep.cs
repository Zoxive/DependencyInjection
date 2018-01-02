namespace App
{

public interface ISaveAllStep {}

public class SaveAllStep : ISaveAllStep
{
	public SaveAllStep
	(
		IAuthorizedEntityRecordService entityRecordService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository,
		IRecordAssignmentsService recordAssignmentsService
	)
	{
	}
}

}
