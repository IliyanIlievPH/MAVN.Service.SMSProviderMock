using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.SmsProviderMock.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }

        public string DataConnString { get; set; }
    }
}
