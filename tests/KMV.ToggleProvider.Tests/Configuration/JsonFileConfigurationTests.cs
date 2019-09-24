using KMV.ToggleProvider.Configuration;
using KMV.ToggleProvider.Tests.TestCases;

using NUnit.Framework;

using static KMV.ToggleProvider.Tests.TestCases.ConfigurationTestCases;

namespace KMV.ToggleProvider.Tests.Configuration
{
    [TestFixture]
    public class JsonFileConfigurationTests
    {
        [Test, TestCaseSource(typeof(ConfigurationTestCases), "TestCases")]
        public void JsonFileConfiguration_ConstructorFull_Success(ConfigurationTestCaseData testCase)
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";

            //Act
            var result = new JsonFileConfiguration(filePath, testCase.IsActiveReload.Value, testCase.DefaultToggleFlag.Value, testCase.UseDefault.Value);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(testCase.ExpectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(testCase.ExpectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(testCase.ExpectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonFileConfiguration_ConstructorNoUseDefault_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";
            bool expectedIsActiveReload = true;
            bool expectedDefaultToggleFlag = true;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonFileConfiguration(filePath, expectedIsActiveReload, expectedDefaultToggleFlag);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonFileConfiguration_ConstructorNoUseDefaultAndDefaultToggleFlag_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";
            bool expectedIsActiveReload = true;
            bool expectedDefaultToggleFlag = false;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonFileConfiguration(filePath, expectedIsActiveReload);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonFileConfiguration_ConstructorNoConfiguratioOptions_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";
            bool expectedIsActiveReload = false;
            bool expectedDefaultToggleFlag = false;
            bool expectedUseDefault = true;

            //Act
            var result = new JsonFileConfiguration(filePath);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(expectedIsActiveReload, result.IsAcvtiveReload);
            Assert.AreEqual(expectedDefaultToggleFlag, result.DefaultToggleFlag);
            Assert.AreEqual(expectedUseDefault, result.UseDefaultToggleFlag);
        }

        [Test]
        public void JsonFileConfiguration_ToggleFileFromConstructor_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";

            //Act
            var result = new JsonFileConfiguration(filePath);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(filePath, result.FilePath);
        }

        [Test]
        public void JsonFileConfiguration_ToggleFileHasBeenChanged_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";
            string filePath2 = @"C:/DammyFile.json";
            var configuration = new JsonFileConfiguration(filePath);

            //Act
            var result = configuration.AddToggleFilePath(filePath2);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(filePath2, result.FilePath);
        }

        [Test]
        public void JsonFileConfiguration_ToggleSectionHasBeenChanged_Success()
        {
            //Arrange
            string filePath = @"C:/DammyFile.json";
            string expectedSectionPath = @"features.toggles";
            var configuration = new JsonFileConfiguration(filePath);

            //Act
            var result = configuration.AddToggleSectionPath(expectedSectionPath);

            //Assert
            Assert.IsNotNull(result, "JsonFileConfiguration can't be null");
            Assert.AreEqual(expectedSectionPath, result.SectionPath);
        }
    }
}
