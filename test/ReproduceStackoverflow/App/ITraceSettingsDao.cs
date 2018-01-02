namespace App
{

public interface ITraceSettingsDao {}

public class TraceSettingsDao : ITraceSettingsDao
{
	public TraceSettingsDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
