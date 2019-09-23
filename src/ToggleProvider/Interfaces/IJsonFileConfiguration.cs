using KMV.ToggleProvider.Configuration;

namespace KMV.ToggleProvider.Interfaces
{
    public interface IJsonFileConfiguration: IBaseToggleConfiguration
    {
        JsonFileConfiguration AddToggleSection(string section);
    }
}
