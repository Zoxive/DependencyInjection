namespace App
{

public interface IResilientRecordRepository {}

public class ResilientRecordRepository : IResilientRecordRepository
{
	public ResilientRecordRepository
	(
		IResilientRecordDao resilientRecordDao
	)
	{
	}
}

}
