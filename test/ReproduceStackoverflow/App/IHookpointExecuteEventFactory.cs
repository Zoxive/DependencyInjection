namespace App
{

public interface IHookpointExecuteEventFactory {}

public class HookpointExecuteEventFactory : IHookpointExecuteEventFactory
{
	public HookpointExecuteEventFactory
	(
		ITraceSettingsRepository traceSettingsRepository
	)
	{
	}
}

}
