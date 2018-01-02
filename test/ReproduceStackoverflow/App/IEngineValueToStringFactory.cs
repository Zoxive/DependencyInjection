namespace App
{

public interface IEngineValueToStringFactory {}

public class EngineValueToStringFactory : IEngineValueToStringFactory
{
	public EngineValueToStringFactory
	(
		IEngineValueToJObjectFactory engineValueToJObjectFactory
	)
	{
	}
}

}
