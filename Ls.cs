using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ls
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ls()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            racine.listeFile.Add(test);
            Assert.AreEqual(racine.listeFile, racine.ls());
        }


    }
}
