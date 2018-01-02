using System.Collections.Generic;

namespace App
{

public interface IEntityFieldXmlSerializer {}

public class EntityFieldXmlSerializer : IEntityFieldXmlSerializer
{
	public EntityFieldXmlSerializer
	(
		IEnumerable<IDataType> dataTypes,
		IValidationXmlSerializer validationSerializer
	)
	{
	}
}

}
