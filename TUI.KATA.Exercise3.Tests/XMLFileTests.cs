using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUI.KATA.Exercise3.Services;
using System.IO;
using System.Reflection;

namespace TUI.KATA.Exercise3.Tests
{
    [TestClass]
    public class XMLFileTests
    {
        [TestMethod]
        public void ReadingXMLFileTest_Success()
        {
            
            string expectedValue = "<test>ceci est un test de lecture de fichier xml</test>";
            string filePath = @"Data\TestFile1.xml";
            var service = new FileServices(filePath);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingXMLFileTest_EmptyFile()
        {
            string expectedValue = string.Empty;
            string filePath = @"Data\TestFile2.xml";
            var service = new FileServices(filePath);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingXMLFileTest_ErrorExtesion()
        {
            string expectedValue = "Error extension";
            string filePath = @"Data\TestFile3.csv";
            var service = new FileServices(filePath);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }


    }
}
