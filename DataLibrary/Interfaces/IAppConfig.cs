namespace DataLibrary.Config
{
    public interface IAppConfig
    {
        string? FilePath { get; }
        Dictionary<string, string> KeyValueConfig { get; }
    }
}
