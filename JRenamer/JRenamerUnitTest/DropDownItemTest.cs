using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JRenamer;

namespace JRenamerUnitTest
{
    [TestClass]
    public class DropDownItemTest
    {
        private string descriptionTest = "Test Description";
        private string maskAll = "*.*";

        [TestMethod]
        public void ToString1()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, maskAll);

            Assert.AreEqual(item.ToString(), descriptionTest);
        }

        [TestMethod]
        public void ToString2()
        {
            DropDownItem item = new DropDownItem(descriptionTest, true, maskAll);

            Assert.AreEqual(item.ToString(), descriptionTest + " (*.*)");
        }

        [TestMethod]
        public void ToString3()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, "*.1", "*.2");

            Assert.AreEqual(item.ToString(), descriptionTest);
        }

        [TestMethod]
        public void ToString4()
        {
            DropDownItem item = new DropDownItem(descriptionTest, true, "*.1", "*.2");

            Assert.AreEqual(item.ToString(), descriptionTest + " (*.1 | *.2)");
        }

        [TestMethod]
        public void GetMaskAsStringSeparatorStandard1()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, maskAll);

            Assert.AreEqual(item.GetMaskAsString(), maskAll);
        }

        [TestMethod]
        public void GetMaskAsStringSeparatorStandard2()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, "*.1", "*.2");

            Assert.AreEqual(item.GetMaskAsString(), "*.1 | *.2");
        }

        [TestMethod]
        public void GetMaskAsStringSeparatorCustom1()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, maskAll);

            Assert.AreEqual(item.GetMaskAsString(", "), maskAll);
        }

        [TestMethod]
        public void GetMaskAsStringSeparatorCustom2()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, "*.1", "*.2");

            Assert.AreEqual(item.GetMaskAsString(", "), "*.1, *.2");
        }

        [TestMethod]
        public void Description1()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, maskAll);

            Assert.AreEqual(item.Description, descriptionTest);
        }

        [TestMethod]
        public void Description2()
        {
            DropDownItem item = new DropDownItem(descriptionTest, true, maskAll);

            Assert.AreEqual(item.Description, descriptionTest);
        }

        [TestMethod]
        public void Description3()
        {
            DropDownItem item = new DropDownItem(descriptionTest, false, "*.1", "*.2");

            Assert.AreEqual(item.Description, descriptionTest);
        }

        [TestMethod]
        public void Description4()
        {
            DropDownItem item = new DropDownItem(descriptionTest, true, "*.1", "*.2");

            Assert.AreEqual(item.Description, descriptionTest);
        }
    }

}
