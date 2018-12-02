using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;

namespace Helper.Tests
{
    [TestClass]
    public class BasePageTest
    {
        protected Browser bpage;
        [TestInitialize]
        public void SetupTest()
        {
            bpage = new Browser();
        }

        [TestMethod]
        public void TestOpenNewTab()
        {
            bpage.OpenNewTab("https://www.google.com");
        }

        [TestCleanup]
        public void TeardownTest()
        {
            bpage.Quit();
        }
    }
}
