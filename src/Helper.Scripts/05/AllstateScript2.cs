using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class AllstateScript2
    {
        protected Allstate a;
        protected DocumentCenter d;

        [TestInitialize]
        public void SetupTest()
        {
            a = new Allstate();
            a.Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            d = new DocumentCenter(a);
            d.ViewMostRecentBills();
        }

        [TestCleanup]
        public void Teardowntest()
        {
            d.Quit();
        }
    }
}
