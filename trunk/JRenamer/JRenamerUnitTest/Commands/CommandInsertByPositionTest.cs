using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JRenamer;

namespace JRenamerUnitTest.Commands
{
    [TestClass]
    public class CommandInsertByPositionTest
    {
        DirectoryFileName directoryFileName_01 = new DirectoryFileName(@"c:\temp\test.txt");

        [TestMethod]
        public void InsertByPosition01_BeginningOneLetter()
        {
            CommandInsertByPosition command = new CommandInsertByPosition(0, BeginningEnd.Beginning, "X");

            directoryFileName_01 = command.Execute(directoryFileName_01);

            Assert.AreEqual(directoryFileName_01.FullName, @"c:\temp\Xtest.txt");
        }
    }
}
