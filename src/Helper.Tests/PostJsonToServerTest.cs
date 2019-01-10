using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.zRecycleBin;
using System.Threading.Tasks;

namespace Helper.Tests
{
    [TestClass]
    public class PostJsonToServerTest
    {
        protected LoginPage page;
        protected LoginPage page2;
        protected LoginPage page3;

        [TestInitialize]
        public async Task SetupTest()
        {
            page = new LoginPage();
            page2 = new LoginPage();
            page3 = new LoginPage();
            await PostJsonToServer.HttpClient(page.Url, "");
        }

        [TestMethod]
        public void AssertAlertButtonEnabled()
        {
            Assert.IsTrue(page.PostVerificationToaster.Enabled);
            Assert.IsTrue(page2.PostVerificationToaster.Enabled);
            Assert.IsTrue(page3.PostVerificationToaster.Enabled);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            page.Quit();
            page2.Quit();
            page3.Quit();
        }
    }
}
