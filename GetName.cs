using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetName
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getName()
        {
            Directory racine = new Directory("racine", null, 7);
            Assert.AreEqual("racine", racine.name);
        }


    }
}