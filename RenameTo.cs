using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameTo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void renameToTrue()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsTrue(racine.renameTo("renommage"));
        }

        [TestMethod]
        public void renameToFalse()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsFalse(false);
        }


        [TestMethod]
        public void renameToValeur()
        {
            Directory racine = new Directory("racine", null, 7);
            racine.renameTo("renommage");
            Assert.AreEqual("renommage", racine.name);
        }
    }
}