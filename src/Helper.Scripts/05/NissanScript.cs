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
            n = new Nissan();
        }

        [TestMethod]
        public void TestMethod1()
        {
            n.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            n.Quit();
        }
    }
}
 