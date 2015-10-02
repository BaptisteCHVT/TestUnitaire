using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetParent 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getParent()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            Assert.AreEqual(racine, test.getParent());
            // la commande parent ne marche pas dans le programme, c'est pour ça que le test unitaire ne marche pas non plus

        }


    }
}