namespace App
{

public interface IHookpointErrorRepository {}

public class HookpointErrorRepository : IHookpointErrorRepository
{
	public HookpointErrorRepository
	(
		IHookpointErrorDao hookpointErrorDao,
		IHookpointErrorMapper hookpointErrorMapper
	)
	{
	}
}

}
