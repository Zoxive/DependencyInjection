namespace App
{

public interface IRuleEngineExceptionMessageFactory {}

public class RuleEngineExceptionMessageFactory : IRuleEngineExceptionMessageFactory
{
	public RuleEngineExceptionMessageFactory
	(
		IFunctionRulesetRepository functionRulesetRepository
	)
	{
	}
}

}
