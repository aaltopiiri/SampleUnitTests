using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_WrongExtension_ReturnsFalse()
        {
            //Arrange - подготовка объекта
            LogAnalyzer analyzer = new LogAnalyzer();
            //Act - воздействие на объект
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            //Assert - утверждение об ожидаемом результате
            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_RightExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.SLF");

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_RightExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.slf");

            Assert.True(result);
        }
    }
}