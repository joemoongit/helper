using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.OtherSites
{
    [TestClass]
    public class AttScript
    {
        protected Att a;

        [TestInitialize]
        public void SetupTest()
        {
            a = new Att();
        }

        [TestMethod]
        public void TestMethod1()
        {
            a.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            a.Quit();
        }
    }
}
