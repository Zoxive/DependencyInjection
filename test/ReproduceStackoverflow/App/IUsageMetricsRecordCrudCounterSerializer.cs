namespace App
{

public interface IUsageMetricsRecordCrudCounterSerializer {}

public class UsageMetricsRecordCrudCounterSerializer : IUsageMetricsRecordCrudCounterSerializer
{
	public UsageMetricsRecordCrudCounterSerializer
	(
		IUsageMetricsRecordCrudCountsFactory usageMetricsRecordCrudCountsFactory
	)
	{
	}
}

}
