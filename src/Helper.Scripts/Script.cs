using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;

namespace Helper.Scripts
{
    [TestClass]
    public class Script
    {
        protected LoginPageOld page;
        protected LoginPageOld page2;
        protected LoginPageOld page3;

        [TestInitialize]
        public void SetupTest()
        {
            page = new LoginPageOld();
        }

        [TestMethod]
        public void RunScript()
        {
            page.OpenNewTab("https://markets.wsj.com");
            page.SwitchTab(0);
            page.SwitchTab("1");
            page.Close();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            page.Quit();
        }
    }
}
