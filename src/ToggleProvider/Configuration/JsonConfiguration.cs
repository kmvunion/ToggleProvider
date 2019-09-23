using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public class JsonConfiguration : BaseConfiguration, IJsonConfiguration
    {
        public string ToggleSection { get; private set; }
        public string FilePath { get; private set; }

        public JsonConfiguration(string filePath) : base()
        {
            FilePath = filePath;
        }

        public JsonConfiguration(string filePath,
            bool isAcvtiveReload = false,
            bool defaultToggleFlag = false,
            bool useDefaultToggleFlag = false) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        {
            FilePath = filePath;
        }

        public JsonConfiguration AddToggleSection(string section)
        {
            ToggleSection = section;
            return this;
        }
    }
}
