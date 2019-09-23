﻿using KMV.ToggleProvider.Configuration;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KMV.ToggleProvider.Providers
{
    public class JsonToggleProvider : BaseToggleProvider<JsonConfiguration>
    {

        public JsonToggleProvider(JsonConfiguration configuration) : base(configuration)
        {
        }

        protected override async Task LoadTogglesAsync()
        {
            if (!File.Exists(_configuration.FilePath))
                throw new FileNotFoundException("Error! Configuration toggles file has not been found!");
            using (StreamReader file = File.OpenText(_configuration.FilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject togglesHolderObject = (JObject)JToken.ReadFrom(reader);
                var toggleSection = togglesHolderObject.SelectToken(_configuration.ToggleSection);

                _toggles = JsonConvert.DeserializeObject<Dictionary<string, bool>>(toggleSection.ToString());
            }
        }
    }
}