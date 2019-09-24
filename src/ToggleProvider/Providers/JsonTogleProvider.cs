using KMV.ToggleProvider.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KMV.ToggleProvider.Providers
{
    public class JsonTogleProvider : BaseToggleProvider<JsonConfiguration>
    {
        public JsonTogleProvider(JsonConfiguration configuration) : base(configuration)
        {
        }

        protected override async Task LoadTogglesAsync()
        {
            _toggles = Task.Run(() =>
            {
                return JsonConvert.DeserializeObject<Dictionary<string, bool>>(_configuration.ToggleSection);
            }).Result;
        }
    }
}
