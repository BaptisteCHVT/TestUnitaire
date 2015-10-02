using System;
using FileSystemTU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void search()
        {
            Directory racine = new Directory("racine", null, 7);
            Directory test = new Directory("test", racine, 7);
            List<File> listeSearch = new List<File>();
            listeSearch.Add(racine);
            Assert.AreEqual(listeSearch, test.search("test"));
        }
        // je n'ai pas vraiment trouvé coment faire le test unitaire du search


    }
}
