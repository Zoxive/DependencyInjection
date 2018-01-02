namespace App
{

public interface IHookpointErrorInMemoryRepository {}

public class HookpointErrorInMemoryRepository : IHookpointErrorInMemoryRepository
{
	public HookpointErrorInMemoryRepository
	(
		IHookpointErrorRepository hookpointErrorRepository
	)
	{
	}
}

}
