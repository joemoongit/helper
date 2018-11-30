using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;
using Helper.Library.Navbar2;

namespace Helper.Scripts
{
    [TestClass]
    public class Script
    {
        protected LoginPage page;
        protected LoginPage page2;
        protected LoginPage page3;

        [TestInitialize]
        public void SetupTest()
        {
            page = new LoginPage("userId", "password");
        }

        [TestMethod]
        public void RunScript()
        {
            page.NavigateTo("https://markets.wsj.com");

        }

        [TestCleanup]
        public void TeardownTest()
        {
            page.Quit();
        }
    }
}
