using KMV.ToggleProvider.Configuration;

namespace KMV.ToggleProvider.Interfaces
{
    public interface IJsonConfiguration: IBaseToggleConfiguration
    {
        JsonConfiguration AddToggleSection(string section);
    }
}
