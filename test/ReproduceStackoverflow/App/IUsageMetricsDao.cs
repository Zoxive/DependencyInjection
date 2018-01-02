namespace App
{

public interface IUsageMetricsDao {}

public class UsageMetricsDao : IUsageMetricsDao
{
	public UsageMetricsDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
