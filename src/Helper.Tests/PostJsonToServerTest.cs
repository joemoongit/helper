using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library;
using System.Threading.Tasks;

namespace Helper.Tests
{
    [TestClass]
    public class PostJsonToServerTest
    {
        protected LoginPageOld page;
        protected LoginPageOld page2;
        protected LoginPageOld page3;

        protected PostJsonToServer post;

        [TestInitialize]
        public async Task SetupTest()
        {
            page = new LoginPageOld();
            page2 = new LoginPageOld();
            page3 = new LoginPageOld();
            post = new PostJsonToServer(page);
            await post.PostToCampaign(10154, 3);
        }

        [TestMethod]
        public void AssertAlertButtonEnabled()
        {
            Assert.IsTrue(page.PostVerificationAlertButton.Enabled);
            Assert.IsTrue(page2.PostVerificationAlertButton.Enabled);
            Assert.IsTrue(page3.PostVerificationAlertButton.Enabled);
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
