using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JRenamer;

namespace JRenamerUnitTest
{
    [TestClass]
    public class FilesOperatorUnitTest
    {
        private static string directory = Directory.GetCurrentDirectory() + "\\TestFiles";

        private static string[] files =
        {
            "NoSpaces.jpg",
            "With Spaces 1.jpg",
            "lowercase.jpg",
            "UPPERCASE.JPG",
            "uppercase extension.JPG",
            "longer extension.jpeg",
            "Mixed case extension.Jpeg",
            "Text File.txt",
            "PNG file.png",
            "TIF file.tif",
            "TIFF file.tiff",
            "GIF file.gif",
            "BMP file.bmp"
        };

        private static string GetFileNamePath(string fileName)
        {
            return directory + "\\" + fileName;
        }

        private static void DeleteDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                foreach (string file in Directory.GetFiles(directory))
                {
                    File.Delete(file);
                }

                Directory.Delete(directory);
            }
        }

        [ClassInitialize]
        public static void InitializeTests(TestContext testContext)
        {
            // Create directory
            DeleteDirectory(directory);
            Directory.CreateDirectory(directory);

            // Create files
            foreach (string file in files)
            {
                string fileNamePath = GetFileNamePath(file);
                var fs = File.CreateText(fileNamePath);
                fs.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                fs.WriteLine("Temp file for testing purposes. Should be deleted.");
                fs.WriteLine(fileNamePath);
                fs.Close();
            }
        }

        [ClassCleanup]
        public static void CleanupTests()
        {
            DeleteDirectory(directory);
        }

        [TestMethod]
        public void AddFiles()
        {
            FilesOperator filesOperator = new FilesOperator(directory);
            filesOperator.GetFiles(false, false);

        }
    }
}
