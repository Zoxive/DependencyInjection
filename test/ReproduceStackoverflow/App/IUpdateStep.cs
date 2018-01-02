namespace App
{

public interface IUpdateStep {}

public class UpdateStep : IUpdateStep
{
	public UpdateStep
	(
		IAuthorizedEntityRecordService entityRecordService,
		IAggregateRootModifiedRepository aggregateRootModifiedRepository,
		IRecordAssignmentsService recordAssignmentsService
	)
	{
	}
}

}
