using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class FbScript
    {
        protected Facebook fb;
        protected FacebookProfilePage profilePage;

        [TestInitialize]
        public void SetupTest()
        {
            fb = new Facebook();
            profilePage = new FacebookProfilePage(fb.Login());
        }

        [TestMethod]
        public void TestMethod1()
        {
            profilePage.Post("test");
        }

        [TestCleanup]
        public void TeardownTest()
        {
            profilePage.Quit();
        }
    }
}
