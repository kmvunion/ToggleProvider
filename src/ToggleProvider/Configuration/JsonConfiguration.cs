using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public class JsonConfiguration : BaseConfiguration, IJsonConfiguration
    {
        public string ToggleSection { get; set; }

        public JsonConfiguration(string toggleSection,
           bool isAcvtiveReload = false,
           bool defaultToggleFlag = false,
           bool useDefaultToggleFlag = true) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        {
            ToggleSection = toggleSection;
        }

        public JsonConfiguration AddJsonTogleSection(string toggleSection)
        {
            ToggleSection = toggleSection;
            return this;
        }
    }
}
