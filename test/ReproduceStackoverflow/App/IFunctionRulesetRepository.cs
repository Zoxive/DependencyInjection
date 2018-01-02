namespace App
{

public interface IFunctionRulesetRepository {}

public class FunctionRulesetRepository : IFunctionRulesetRepository
{
	public FunctionRulesetRepository
	(
		IFunctionRulesetDao functionRulesetDao,
		IFunctionRulesetFactory functionRulesetFactory,
		IRulesetRepository rulesetRepository,
		IKeystoneApplicationRowCacherFactory cacherFactory
	)
	{
	}
}

}
