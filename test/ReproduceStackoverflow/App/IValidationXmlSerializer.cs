namespace App
{

public interface IValidationXmlSerializer {}

public class ValidationXmlSerializer : IValidationXmlSerializer
{
	public ValidationXmlSerializer
	(
		IEntityFieldValidatorFactory factory
	)
	{
	}
}

}
