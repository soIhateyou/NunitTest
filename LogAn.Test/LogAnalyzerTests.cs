using System;
using NUnit.Framework;

namespace LogAn.Test
{
    [TestFixture] 
    public class LogAnalyzerTests 
    {
        private LogAnalyzer _analyzer;

        [SetUp]
        public void Setup()
        {
            _analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result = _analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result,"filename should be valid!");
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            bool result = _analyzer.IsValidLogFileName("whatever.SLF");
            Assert.IsTrue(result,"filename should be valid");
        }

        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "No log file with that name exists")]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            _analyzer.IsValidLogFileName(string.Empty);
        }

        [Test]
        //[Ignore("这个测试有问题")]
        [Category("运行快的测试")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
            bool result = _analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        public void IsValidLogFileName_ValidName_RemembersTrue()
        {
            LogAnalyzer log = new LogAnalyzer();
            log.IsValidLogFileName("somefile.slf");
            Assert.IsTrue(log.wasLastFileNameValid);
        }

        [TearDown]
        public void TearDown()
        {
            _analyzer = null;
        }
    }
}
