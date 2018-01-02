namespace App
{

public interface IConfigurationManagerAppSettingsRepository {}

public class ConfigurationManagerAppSettingsRepository : IConfigurationManagerAppSettingsRepository
{
	public ConfigurationManagerAppSettingsRepository
	(
		NameValueCollection appSettings
	)
	{
	}
}

}
