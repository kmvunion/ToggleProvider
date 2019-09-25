using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public class JsonConfiguration : BaseConfiguration, IJsonConfiguration
    {
        /// <summary>
        /// Toggles dictionary JSON representation. It must serialized from Dictionary<string,bool> where 
        /// key is feature name and value is boolean flag of the toggle
        /// </summary>
        public string ToggleSection { get; set; }

        public JsonConfiguration(string toggleSection,
           bool isAcvtiveReload = false,
           bool defaultToggleFlag = false,
           bool useDefaultToggleFlag = true) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        {
            ToggleSection = toggleSection;
        }

        /// <summary>
        /// Add or replace Toggles dictionary JSON representation option. 
        /// </summary>
        /// <param name="toggleSection">Toggles dictionary JSON representation. It must serialized from Dictionary(string,bool) where 
        /// key is feature name and value is boolean flag of the toggle</param>
        /// <returns>Return the same instance of configuration</returns>
        public JsonConfiguration AddJsonTogleSection(string toggleSection)
        {
            ToggleSection = toggleSection;
            return this;
        }
    }
}
