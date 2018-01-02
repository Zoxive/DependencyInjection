namespace App
{

public interface ISystemHookpointDao {}

public class SystemHookpointDao : ISystemHookpointDao
{
	public SystemHookpointDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
