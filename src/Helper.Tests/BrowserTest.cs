using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;
using OpenQA.Selenium;

namespace Helper.Tests
{
    [TestClass]
    public class BrowserTest
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
            WebDriver.WaitUntilElementIsVisible(bpage.webDriver(), By.TagName("body"), 5);
            Assert.IsTrue(bpage.webDriver().FindElement(By.XPath("//*[@id=\"hplogo\"]")).Displayed);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            bpage.Quit();
        }
    }
}
