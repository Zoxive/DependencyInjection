namespace App
{

public interface ITraceWriterFactory {}

public class TraceWriterFactory : ITraceWriterFactory
{
	public TraceWriterFactory
	(
		ICurrentUser currentUser,
		IRuleTypeRepository ruleTypeRepository,
		IEngineValueToStringFactory engineValueToStringFactory,
		IBackgroundTaskQueueService backgroundTaskQueueService
	)
	{
	}
}

}
