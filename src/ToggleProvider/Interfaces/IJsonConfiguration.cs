using KMV.ToggleProvider.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMV.ToggleProvider.Interfaces
{
    public interface IJsonConfiguration : IBaseToggleConfiguration
    {
        JsonConfiguration AddJsonTogleSection(string section);        
    }
}
