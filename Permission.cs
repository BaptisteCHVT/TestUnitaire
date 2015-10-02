using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Permission
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void canRead()
        {
            Directory test = new Directory("test", null, 7);
            Assert.IsTrue(test.canRead());

        }

        [TestMethod]
        public void canNotRead()
        {
            Directory test = new Directory("test", null, 0);
            Assert.IsFalse(test.canRead());

        }

        [TestMethod]
        public void canWrite()
        {
            Directory test = new Directory("test", null, 7);
            Assert.IsTrue(test.canWrite());

        }

        [TestMethod]
        public void canNotWrite()
        {
            Directory test = new Directory("test", null, 0);
            Assert.IsFalse(test.canWrite());

        }

        [TestMethod]
        public void canExecute()
        {
            Directory test = new Directory("test", null, 7);
            Assert.IsTrue(test.canExecute());

        }

        [TestMethod]
        public void canNotExecute()
        {
            Directory test = new Directory("test", null, 0);
            Assert.IsFalse(test.canExecute());

        }
    }
}
