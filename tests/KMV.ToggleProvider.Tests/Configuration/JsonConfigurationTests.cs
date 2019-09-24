using KMV.ToggleProvider.Configuration;
using KMV.ToggleProvider.Tests.TestCases;

using NUnit.Framework;

using static KMV.ToggleProvider.Tests.TestCases.ConfigurationTestCases;

namespace KMV.ToggleProvider.Tests.Configuration
{
    [TestFixture]
    public class JsonConfigurationTests
    {
        [Test, TestCaseSource(typeof(ConfigurationTestCases), "TestCases")]
        public void JsonConfiguration_ConstructorFull_Success(ConfigurationTestCaseData testCase)
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";

            //Act
            var result = new JsonConfiguration(toggleSection, testCase.IsActiveReload.Value, testCase.DefaultToggleFlag.Value, testCase.UseDefault.Value);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(testCase.ExpectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(testCase.ExpectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(testCase.ExpectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonConfiguration_ConstructorNoUseDefault_Success()
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";
            bool expectedIsActiveReload = true;
            bool expectedDefaultToggleFlag = true;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonConfiguration(toggleSection, expectedIsActiveReload, expectedDefaultToggleFlag);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonConfiguration_ConstructorNoUseDefaultAndDefaultToggleFlag_Success()
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";
            bool expectedIsActiveReload = true;
            bool expectedDefaultToggleFlag = false;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonConfiguration(toggleSection, expectedIsActiveReload);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonConfiguration_ConstructorNoConfiguratioOptions_Success()
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";
            bool expectedIsActiveReload = false;
            bool expectedDefaultToggleFlag = false;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonConfiguration(toggleSection);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonConfiguration_ToggleSectionFromConstructor_Success()
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";

            //Act
            var result = new JsonConfiguration(toggleSection);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(toggleSection, result.ToggleSection);
        }

        [Test]
        public void JsonConfiguration_ToggleSectionHasBeenChanged_Success()
        {
            //Arrange
            string toggleSection = @"{""toggle"":{}}";
            string toggleSection2 = @"{""toggle2"":{}}";
            var configuration = new JsonConfiguration(toggleSection);

            //Act
            var result = configuration.AddJsonTogleSection(toggleSection2);

            //Assert
            Assert.IsNotNull(result, "JsconConfiguration can't be null");
            Assert.AreEqual(toggleSection2, result.ToggleSection);
        }
    }
}
