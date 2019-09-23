﻿using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public class JsonFileConfiguration : BaseConfiguration, IJsonFileConfiguration
    {
        public string SectionPath { get; private set; }
        public string FilePath { get; private set; }

        public JsonFileConfiguration(string filePath) : base()
        {
            FilePath = filePath;
        }

        public JsonFileConfiguration(string filePath,
            bool isAcvtiveReload = false,
            bool defaultToggleFlag = false,
            bool useDefaultToggleFlag = false) : base(isAcvtiveReload, defaultToggleFlag, useDefaultToggleFlag)
        {
            FilePath = filePath;
        }

        public JsonFileConfiguration AddToggleSection(string sectionPath)
        {
            SectionPath = sectionPath;
            return this;
        }
    }
}
