namespace App
{

public interface IHookpointErrorDao {}

public class HookpointErrorDao : IHookpointErrorDao
{
	public HookpointErrorDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
