namespace App
{

public interface ITraceExpressionEventFactory {}

public class TraceExpressionEventFactory : ITraceExpressionEventFactory
{
	public TraceExpressionEventFactory
	(
		IEngineValueToStringFactory engineValueToStringFactory
	)
	{
	}
}

}
