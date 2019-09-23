using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public abstract class BaseConfiguration : IBaseToggleConfiguration
    {
        public bool IsAcvtiveReload { get; set; } 

        public bool DefaultToggleFlag { get; set; } 

        public bool UseDefaultToggleFlag { get; set; } 

        protected BaseConfiguration(bool isAcvtiveReload = false, bool defaultToggleFlag = false, bool useDefaultToggleFlag = false)
        {
            IsAcvtiveReload = isAcvtiveReload;
            DefaultToggleFlag = defaultToggleFlag;
            UseDefaultToggleFlag = useDefaultToggleFlag;
        }


        public virtual void SetAcvtiveReload(bool value = true)
        {
            IsAcvtiveReload = value;
        }

        public virtual void SetDefaultToggleFlag(bool defaultToggleFlag = true)
        {
            DefaultToggleFlag = defaultToggleFlag;
            UseDefaultToggleFlag = true;
        }
    }
}
