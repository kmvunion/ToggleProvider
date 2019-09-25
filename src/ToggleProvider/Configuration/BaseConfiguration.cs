using KMV.ToggleProvider.Interfaces;

namespace KMV.ToggleProvider.Configuration
{
    public abstract class BaseConfiguration : IBaseToggleConfiguration
    {
        /// <summary>
        /// Gets or Sets possibility to reload feature toggles data each time when it 
        /// requested from the functionality. 
        /// </summary>
        public bool IsAcvtiveReload { get; set; }

        /// <summary>
        /// Gets or sets Default toggle flag. This option is applied when UseDefaultToggleFlag = true
        /// </summary>
        public bool DefaultToggleFlag { get; set; }

        /// <summary>
        /// Gets or sets Directive option to use or not default toggle set in DefaultToggleFlag
        /// </summary>
        public bool UseDefaultToggleFlag { get; set; } 

        protected BaseConfiguration(bool isAcvtiveReload = false, bool defaultToggleFlag = false, bool useDefaultToggleFlag = true)
        {
            IsAcvtiveReload = isAcvtiveReload;
            DefaultToggleFlag = defaultToggleFlag;
            UseDefaultToggleFlag = useDefaultToggleFlag;
        }

        /// <summary>
        /// Set option value of possibility to reload feature toggles data each time when it 
        /// requested from the functionality.
        /// </summary>
        /// <param name="value">Value of option IsActivReload</param>
        public virtual void SetAcvtiveReload(bool value = true)
        {
            IsAcvtiveReload = value;
        }

        /// <summary>
        /// Set default toggle flag
        /// </summary>
        /// <param name="defaultToggleFlag">Value of default toggle flag </param>        
        public virtual void SetDefaultToggleFlag(bool defaultToggleFlag = true)
        {
            DefaultToggleFlag = defaultToggleFlag;
            UseDefaultToggleFlag = true;
        }
    }
}
