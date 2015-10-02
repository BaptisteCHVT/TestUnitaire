using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetRoot
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void getRoot()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            Assert.AreEqual(racine, test.parent);
        }

    }
}
