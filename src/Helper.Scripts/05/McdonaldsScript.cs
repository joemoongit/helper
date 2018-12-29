using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts._05
{
    [TestClass]
    public class McdonaldsScript
    {
        protected Mcdonalds m;

        [TestInitialize]
        public void SetupTest()
        {
            m = new Mcdonalds();
        }

        [TestMethod]
        public void TestMethod1()
        {
            m.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            m.Quit();
        }
    }
}
