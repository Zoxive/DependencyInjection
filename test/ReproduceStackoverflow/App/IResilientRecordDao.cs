namespace App
{

public interface IResilientRecordDao {}

public class ResilientRecordDao : IResilientRecordDao
{
	public ResilientRecordDao
	(
		IKeystoneApplicationDatabase database
	)
	{
	}
}

}
