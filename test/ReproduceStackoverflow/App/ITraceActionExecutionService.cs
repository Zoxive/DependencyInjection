namespace App
{

public interface ITraceActionExecutionService {}

public class TraceActionExecutionService : ITraceActionExecutionService
{
	public TraceActionExecutionService
	(
		ITraceEventListenerFactory traceEventListenerFactory
	)
	{
	}
}

}
