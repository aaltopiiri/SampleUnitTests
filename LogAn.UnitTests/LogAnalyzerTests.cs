using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            //Arrange - подготовка объекта
            LogAnalyzer analyzer = new LogAnalyzer();
            //Act - воздействие на объект
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            //Assert - утверждение об ожидаемом результате
            Assert.False(result);
        }

        [TestCase ("filewithgoodextension.SLF")]
        [TestCase ("filewithgoodextension.slf")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            Assert.True(result);
        }

    }
}