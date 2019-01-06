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
            a = new Att().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestCleanup]
        public void TeardownTest()
        {
            a.Quit();
        }
    }
}
