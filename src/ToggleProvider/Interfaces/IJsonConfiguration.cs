using KMV.ToggleProvider.Configuration;

namespace KMV.ToggleProvider.Interfaces
{
    public interface IJsonConfiguration : IBaseToggleConfiguration
    {
        JsonConfiguration AddJsonTogleSection(string toggleSection);        
    }
}
