using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;
using OpenQA.Selenium;

namespace Helper.Tests
{
    [TestClass]
    public class BrowserTest
    {
        protected Browser page;

        [TestInitialize]
        public void SetupTest()
        {
            page = new Browser();
        }

        [TestMethod]
        public void TestOpenNewTab()
        {
            page.Initalize();
            page.OpenNewTab("https://www.google.com");
            WebDriver.WaitUntilElementIsVisible(page.webDriver, By.TagName("body"), 5);
            Assert.IsTrue(page.webDriver.FindElement(By.XPath("//*[@id=\"hplogo\"]")).Displayed);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            page.Quit();
        }
    }
}
