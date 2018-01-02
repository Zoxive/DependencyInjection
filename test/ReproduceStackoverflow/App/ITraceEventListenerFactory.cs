namespace App
{

public interface ITraceEventListenerFactory {}

public class TraceEventListenerFactory : ITraceEventListenerFactory
{
	public TraceEventListenerFactory
	(
		IEntityDefinitionRepository entityDefinitionRepository
	)
	{
	}
}

}
