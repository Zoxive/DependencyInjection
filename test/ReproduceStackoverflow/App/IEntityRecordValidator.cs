namespace App
{

public interface IEntityRecordValidator {}

public class EntityRecordValidator : IEntityRecordValidator
{
	public EntityRecordValidator
	(
		ICurrentUser currentUser,
		IEntityFieldValidationService entityFieldValidationService
	)
	{
	}
}

}
