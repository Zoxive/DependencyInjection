namespace App
{

public interface ITraceSettingsRepository {}

public class TraceSettingsRepository : ITraceSettingsRepository
{
	public TraceSettingsRepository
	(
		ITraceSettingsDao traceSettingsDao
	)
	{
	}
}

}
