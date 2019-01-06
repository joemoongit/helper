using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class DirectvnowScript
    {
        protected Directvnow d;

        [TestInitialize]
        public void SetupTest()
        {
            d = new Directvnow().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestCleanup]
        public void TeardownTest()
        {
            d.Quit();
        }
    }
}
