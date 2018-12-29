using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class ToyotaScript
    {
        protected Toyota t;

        [TestInitialize]
        public void SetupTest()
        {
            t = new Toyota();
        }

        [TestMethod]
        public void TestMethod1()
        {
            t.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            t.Quit();
        }
    }
}
