using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mkdir
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void newDirectoryTrue()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsTrue(racine.mkdir("test"));
        }

        [TestMethod]
        public void newDirectoryFalse()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void mkdirAjoutList()
        {
            Directory racine = new Directory("racine", null, 7);
            racine.mkdir("test");
            Assert.AreEqual(1, racine.listeFile.Count);
        }

        [TestMethod]
        public void mkdirValeur()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            racine.createNewFile("test");
            Assert.AreEqual("test", test.name);
            Assert.AreEqual(racine, test.parent);
            Assert.AreEqual(7, test.permission);
        }
    }
}
