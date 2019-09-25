using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public class JsonFileConfiguration : BaseConfiguration, IJsonFileConfiguration
    {
        /// <summary>
        /// Path to the JSON toggles configuration in the JSON file. 
        /// </summary>
        public string SectionPath { get; private set; }

        /// <summary>
        /// Path to the file contained JSON toggles configuration. Configuration must be represented as a Dictionary(string,bool) where key is
        /// string feature name and value is boolean toggle value flag
        /// <example> 
        /// For instance:
        /// <code>
        /// "root.features"
        /// </code>
        /// </example>
        /// </summary>
        public string FilePath { get; private set; }

        public JsonFileConfiguration(string filePath) : base()
        {
            FilePath = filePath;
        }

        //public JsonFileConfiguration(string filePath, bool isAcvtiveReload = false, bool defaultToggleFlag = false, bool useDefaultToggleFlag = true) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        public JsonFileConfiguration(string filePath, bool isAcvtiveReload, bool defaultToggleFlag, bool useDefaultToggleFlag) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        {
            FilePath = filePath;
        }

        /// <summary>
        /// Adding section path of JSON toggles configuration in the configuration file. 
        /// Configuration must be represented as a Dictionary(string,bool) where key is
        /// string feature name and value is boolean toggle value flag
        /// <example> 
        /// For instance:
        /// <code>
        /// "root.features"
        /// </code>
        /// </example>
        /// </summary>
        public JsonFileConfiguration AddToggleSectionPath(string sectionPath)
        {
            SectionPath = sectionPath;
            return this;
        }

        /// <summary>
        /// Adding path of the JSON file configuration.
        /// </summary>
        public JsonFileConfiguration AddToggleFilePath(string filePath)
        {
            FilePath = filePath;
            return this;
        }
    }
}
