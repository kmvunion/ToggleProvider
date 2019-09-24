using NUnit.Framework;

using System.Collections;

namespace KMV.ToggleProvider.Tests.TestCases
{
    public class ConfigurationTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                //(IsActiveReload, DefaultToggleFlag, UseDefault, ExpectedIsActiveReload, ExpectedDefaultToggleFlag, ExpectedUseDefault)
                yield return new TestCaseData(new ConfigurationTestCaseData(false, false, false, false, false, false));
                yield return new TestCaseData(new ConfigurationTestCaseData(false, false, true, false, false, true));
                yield return new TestCaseData(new ConfigurationTestCaseData(false, true, false, false, true, false));
                yield return new TestCaseData(new ConfigurationTestCaseData(false, true, true, false, true, true));
                yield return new TestCaseData(new ConfigurationTestCaseData(true, false, false, true, false, false));
                yield return new TestCaseData(new ConfigurationTestCaseData(true, false, true, true, false, true));
                yield return new TestCaseData(new ConfigurationTestCaseData(true, true, false, true, true, false));
                yield return new TestCaseData(new ConfigurationTestCaseData(true, true, true, true, true, true));
            }
        }

        public class ConfigurationTestCaseData
        {
            public bool? IsActiveReload { get; private set; }
            public bool? DefaultToggleFlag { get; private set; }
            public bool? UseDefault { get; private set; }
            public bool ExpectedIsActiveReload { get; private set; }
            public bool ExpectedDefaultToggleFlag { get; private set; }
            public bool ExpectedUseDefault { get; private set; }

            public ConfigurationTestCaseData(bool? isActiveReload, bool? defaultToggleFlag, bool? useDefault,
                bool expectedIsActiveReload, bool expectedDefaultToggleFlag, bool expectedUseDefault)
            {
                IsActiveReload = isActiveReload;
                DefaultToggleFlag = defaultToggleFlag;
                UseDefault = useDefault;
                ExpectedIsActiveReload = expectedIsActiveReload;
                ExpectedDefaultToggleFlag = expectedDefaultToggleFlag;
                ExpectedUseDefault = expectedUseDefault;
            }
        }
    }
}
