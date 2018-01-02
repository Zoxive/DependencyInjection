using System.Collections.Generic;

namespace App
{

public interface IEntityFieldValidationService {}

public class EntityFieldValidationService : IEntityFieldValidationService
{
	public EntityFieldValidationService
	(
		IEnumerable<IFieldValidatorService> fieldValidatorServices
	)
	{
	}
}

}
