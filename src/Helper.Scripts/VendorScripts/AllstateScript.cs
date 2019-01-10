using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class AllstateScript
    {
        protected Allstate a;

        [TestInitialize]
        public void SetupTest()
        {
            a = new Allstate().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var d = new DocumentCenter(a);
            d.ViewMostRecentBills();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            a.Quit();
        }
    }
}
