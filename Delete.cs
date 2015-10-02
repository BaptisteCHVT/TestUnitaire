using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void deleteTrue()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            racine.listeFile.Add(test);
            Assert.IsTrue(racine.delete("test"));
        }

        public void deleteFalse()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            racine.listeFile.Add(test);
            Assert.IsFalse(racine.delete(""));
        }


    }
}