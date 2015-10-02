using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsDirectory
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void isDirectory()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            Assert.IsTrue(test.isDirectory());
        }

        [TestMethod]
        public void isNotDirectory()
        {
            Directory racine = new Directory("racine", null, 7);
            File test = new File("test", racine, 7);
            Assert.IsFalse(test.isDirectory());
        }

    }
}
