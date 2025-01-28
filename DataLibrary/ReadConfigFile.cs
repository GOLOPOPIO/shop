using System.IO;

namespace DataLibrary.Config
{
    public static class ReadConfigFile
    {
        public static string[][] GetKeyValue(string? FilePath, int valueCount)
        {
            string[][] keyValues = new string[valueCount][];
            StreamReader file;

            using (file = new StreamReader(FilePath ?? throw new ArgumentNullException()))
            {
                try
                {
                    for (int i = 0; i < valueCount; i++)
                        keyValues[i] = file?.ReadLine()?.Split('=') ?? throw new ArgumentNullException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                return keyValues;
            }
        }
    }
}
