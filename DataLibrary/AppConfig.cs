
namespace DataLibrary.Config
{
    public class AppConfig : IAppConfig
    {
        public string FilePath { get; private set; }
        public Dictionary<string, string> KeyValueConfig {  get; private set; } = new Dictionary<string, string>();
        public int ValuesCount { get; private set; }

        public AppConfig(string file, int valuesCount)
        {
            FilePath = file;
            ValuesCount = valuesCount;


            if (file == null) throw new ArgumentNullException(nameof(file));
            string[][] keyvalue = ReadConfigFile.GetKeyValue(FilePath, ValuesCount);

            for (int i = 0; i < ValuesCount; i++)
            {
                KeyValueConfig.Add(keyvalue[i][0], keyvalue[i][2]);
            }
        }

        public void Reload(string file, int valuesCount)
        {
            var n = new AppConfig(file, valuesCount);
            FilePath = n.FilePath;
            ValuesCount = n.ValuesCount;
            KeyValueConfig = n.KeyValueConfig;
        } 
    }
}
