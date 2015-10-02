using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetPath
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void getPath()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            Assert.AreEqual("testracine", test.getPath());   
            // un petit problème dans ma méthode m'oblige à comparer"testracine" pour que le TU marche
        }

    }
}
