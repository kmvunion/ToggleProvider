namespace KMV.ToggleProvider.Interfaces
{
    public interface IBaseToggleConfiguration
    {
        bool IsAcvtiveReload { get; set; }

        bool DefaultToggleFlag { get; set; }

        bool UseDefaultToggleFlag { get; set; }

        void SetDefaultToggleFlag(bool defaultToggleFlag = true);

        void SetAcvtiveReload(bool value = true);
    }
}
