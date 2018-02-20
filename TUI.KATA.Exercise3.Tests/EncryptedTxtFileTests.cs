using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUI.KATA.Exercise3.Services;
using System.IO;
using System.Reflection;

namespace TUI.KATA.Exercise3.Tests
{
    [TestClass]
    public class EncryptedTxtFileTests
    {
        [TestMethod]
        public void ReadingEncryptedTXTFileTest_Success()
        {
            
            string expectedValue = "Ceci est un text decrypte";
            string filePath = @"Data\TestFileEncrypted1.txt";
            var service = new FileServices(filePath, true);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingEncryptedTXTFileTest_EmptyFile()
        {
            string expectedValue = string.Empty;
            string filePath = @"Data\TestFileEncrypted2.txt";
            var service = new FileServices(filePath, true);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingEncryptedTXTFileTest_ErrorExtesion()
        {
            string expectedValue = "Error extension";
            string filePath = @"Data\TestFileEncrypted3.csv";
            var service = new FileServices(filePath, true);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }


    }
}
