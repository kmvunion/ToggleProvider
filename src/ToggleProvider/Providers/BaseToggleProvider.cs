using KMV.ToggleProvider.Configuration;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KMV.ToggleProvider.Providers
{
    public abstract class BaseToggleProvider<T> : IToggleProvider where T : BaseConfiguration
    {
        protected Dictionary<string, bool> _toggles = new Dictionary<string, bool>();

        protected T _configuration;

        protected BaseToggleProvider(T configuration)
        {
            _configuration = configuration;
            ForceReloadAsync().GetAwaiter();
        }

        public void ForceReload()
        {
            Task.FromResult(LoadTogglesAsync());
        }

        public async Task ForceReloadAsync()
        {
            await LoadTogglesAsync();
        }

        public bool GetToggleValue(string toggleName)
        {
            return GetToggleValueAsync(toggleName).Result;
        }

        public async Task<bool> GetToggleValueAsync(string toggleName)
        {
            if (_configuration.IsAcvtiveReload)
            {
                await LoadTogglesAsync();
            }

            if (_toggles.TryGetValue(toggleName, out var value))
            {
                return value;
            }

            if (_configuration.UseDefaultToggleFlag)
            {
                return _configuration.DefaultToggleFlag;
            }

            throw new ArgumentException($"Error! Toggle {toggleName} has not been found.", "toggleName");
        }        

        protected abstract Task LoadTogglesAsync();

    }
}
