using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj.Tests
{
    [TestFixture]
    class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }


        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
           

            bool result = m_analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {

            bool result =
                m_analyzer.IsValidLogFileName("whatever.SLF");
            Assert.IsTrue(result, "filename should be valid!");

            
        }


        [Test]
        [ExpectedException(typeof(ArgumentException), 
            ExpectedMessage = "No filename provided!")]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            m_analyzer.IsValidLogFileName(string.Empty);
        }


        [Test]
        public void IsValidLogFileName_ValidName_RemembersTrue()
        {
            LogAnalyzer log = new LogAnalyzer();

            log.IsValidLogFileName("somefile.slf");

            Assert.IsTrue(log.WasLastFileNameValid);
        }


        [Test]
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();

            myFakeManager.ShouldExtensionBeValid = true;

            ExtensionManagerFactory
                .SetManager(myFakeManager);




            LogAnalyzer log = new LogAnalyzer();

            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "File name with less than 5 chars should have failed the method, even if the extension is supported");


        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }





    }
}
