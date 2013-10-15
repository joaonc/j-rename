using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JRenamer;

namespace JRenamerUnitTest
{
    [TestClass]
    public class DirectoryFileNameTest
    {
        DirectoryFileName directoryFileName_01 = new DirectoryFileName(@"c:\temp\test.txt");
        DirectoryFileName directoryFileName_02 = new DirectoryFileName(@"c:\temp1\temp2\test1.test2.txt");
        DirectoryFileName directoryFileName_03 = new DirectoryFileName(@"c:\temp1.temp2\test .txt");
        DirectoryFileName directoryFileName_04 = new DirectoryFileName(@"c:\temp space\test");

        [TestMethod]
        public void FileName_01()
        {
            Assert.AreEqual("test.txt", directoryFileName_01.FileName);
        }

        [TestMethod]
        public void FileName_02()
        {
            Assert.AreEqual("test1.test2.txt", directoryFileName_02.FileName);
        }

        [TestMethod]
        public void FileName_03()
        {
            Assert.AreEqual("test .txt", directoryFileName_03.FileName);
        }

        [TestMethod]
        public void FileName_04()
        {
            Assert.AreEqual("test", directoryFileName_04.FileName);
        }

        [TestMethod]
        public void DirectoryName_01()
        {
            Assert.AreEqual(@"c:\temp", directoryFileName_01.DirectoryName);
        }

        [TestMethod]
        public void DirectoryName_02()
        {
            Assert.AreEqual(@"c:\temp1\temp2", directoryFileName_02.DirectoryName);
        }

        [TestMethod]
        public void DirectoryName_03()
        {
            Assert.AreEqual(@"c:\temp1.temp2", directoryFileName_03.DirectoryName);
        }

        [TestMethod]
        public void DirectoryName_04()
        {
            Assert.AreEqual(@"c:\temp space", directoryFileName_04.DirectoryName);
        }

        [TestMethod]
        public void FullName_01()
        {
            Assert.AreEqual(@"c:\temp\test.txt", directoryFileName_01.FullName);
        }

        [TestMethod]
        public void FullName_02()
        {
            Assert.AreEqual(@"c:\temp1\temp2\test1.test2.txt", directoryFileName_02.FullName);
        }

        [TestMethod]
        public void FullName_03()
        {
            Assert.AreEqual(@"c:\temp1.temp2\test .txt", directoryFileName_03.FullName);
        }

        [TestMethod]
        public void FullName_04()
        {
            Assert.AreEqual(@"c:\temp space\test", directoryFileName_04.FullName);
        }

        [TestMethod]
        public void FileNameWithoutExtension_01()
        {
            Assert.AreEqual(@"test", directoryFileName_01.FileNameWithoutExtension);
        }

        [TestMethod]
        public void FileNameWithoutExtension_02()
        {
            Assert.AreEqual(@"test1.test2", directoryFileName_02.FileNameWithoutExtension);
        }

        [TestMethod]
        public void FileNameWithoutExtension_03()
        {
            Assert.AreEqual(@"test ", directoryFileName_03.FileNameWithoutExtension);
        }

        [TestMethod]
        public void FileNameWithoutExtension_04()
        {
            Assert.AreEqual(@"test", directoryFileName_04.FileNameWithoutExtension);
        }
    }
}
