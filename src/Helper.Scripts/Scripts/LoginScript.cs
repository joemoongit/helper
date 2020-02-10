using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class LoginScript
    {
        protected Facebook fb;
        protected Github github;
        protected Gmail gmail;
        protected Youtube youtube;

        [TestInitialize]
        public void SetupTest()
        {
            github = new Github();
            fb = new Facebook();
            gmail = new Gmail();
            youtube = new Youtube();
        }

        [TestMethod]
        public void TestSites()
        {
            github.Login();
            fb.Login();
            gmail.Login();
            youtube.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            fb.Quit();
            github.Quit();
            gmail.Quit();
            youtube.Quit();
        }
    }
}
