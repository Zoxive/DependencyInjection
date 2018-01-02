namespace App
{

public interface IFunctionRulesetDao {}

public class FunctionRulesetDao : IFunctionRulesetDao
{
	public FunctionRulesetDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
