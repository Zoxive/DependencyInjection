namespace App
{

public class TraceDelegatingHandler
{
	public TraceDelegatingHandler
	(
		ITraceWriterFactory traceWriterFactory,
		ITraceActionExecutionService traceActionExecutionService,
		ITraceSettingsRepository traceSettingsRepository
	)
	{
	}
}

}
