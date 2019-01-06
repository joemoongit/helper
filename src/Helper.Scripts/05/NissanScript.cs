using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;
using Helper.Library;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class NissanScript
    {
        protected Nissan n;

        [TestInitialize]
        public void SetupTest()
        {
            n = new Nissan().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestCleanup]
        public void TeardownTest()
        {
            n.Quit();
        }
    }
}
 