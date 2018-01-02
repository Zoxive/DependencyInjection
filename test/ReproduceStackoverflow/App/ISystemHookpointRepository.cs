namespace App
{

public interface ISystemHookpointRepository {}

public class SystemHookpointRepository : ISystemHookpointRepository
{
	public SystemHookpointRepository
	(
		ISystemHookpointDao systemHookpointDao,
		ISystemHookpointFactory systemHookpointFactory,
		IRulesetRepository rulesetRepository
	)
	{
	}
}

}
