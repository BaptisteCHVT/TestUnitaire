using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace createNewFile
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void createFileTrue()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsTrue(racine.createNewFile("test"));
        }

        [TestMethod]
        public void createFileFalse()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.IsFalse(false);
        }


        [TestMethod]
        public void createAjoutListe()
        {
            Directory racine = new Directory("racine", null, 7);
            racine.createNewFile("test");
            Assert.AreEqual(1, racine.listeFile.Count);
        }

        [TestMethod]
        public void createValeur()
        {
            Directory racine = new Directory("racine", null, 7);
            File test = new File("test", racine, 7);
            racine.createNewFile("test");
            Assert.AreEqual("test", test.name);
            Assert.AreEqual(racine, test.parent);
            Assert.AreEqual(7, test.permission);
        }
    }
}
