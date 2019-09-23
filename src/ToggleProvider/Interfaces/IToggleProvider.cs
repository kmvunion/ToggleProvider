using KMV.ToggleProvider.Configuration;
using System.Threading.Tasks;

namespace KMV.ToggleProvider
{
    public interface IToggleProvider
    {
        Task<bool> GetToggleValueAsync(string toggleName);

        bool GetToggleValue(string toggleName);

        Task ForceReloadAsync();

        void ForceReload();
    }
}
