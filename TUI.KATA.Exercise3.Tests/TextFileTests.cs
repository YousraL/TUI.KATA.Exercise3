using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUI.KATA.Exercise3.Services;
using System.IO;
using System.Reflection;

namespace TUI.KATA.Exercise3.Tests
{
    [TestClass]
    public class TextFileTests
    {
        [TestMethod]
        public void ReadingFileTest_Success()
        {
            
            string expectedValue = "Ceci est un test de lecture d'un fichier .txt";
            string filePath = @"Data\TestFile1.txt";
            var service = new FileServices(filePath);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingFileTest_EmptyFile()
        {
            string expectedValue = string.Empty;
            string filePath = @"Data\TestFile2.txt";
            var service = new FileServices(filePath);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }


    }
}
