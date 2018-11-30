using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;

namespace Helper.Tests
{
    [TestClass]
    public class BasePageTest
    {
        protected BasePage bpage;
        [TestInitialize]
        public void SetupTest()
        {
            bpage = new BasePage();
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
