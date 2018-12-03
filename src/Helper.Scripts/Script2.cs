using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.sites;

namespace Helper.Scripts
{
    [TestClass]
    public class Script2
    {
        protected Facebook fb;
        protected Github github;
        protected Gmail gmail;
        protected Packtpub packtpub;

        [TestInitialize]
        public void SetupTest()
        {
            github = new Github();
            fb = new Facebook();
            gmail = new Gmail();
            packtpub = new Packtpub();
        }

        [TestMethod]
        public void TestSites()
        {
            github.Login("userId", "pw");
            fb.Login("userId", "pw");
            gmail.Login("userId", "pw");
            packtpub.Login("userId", "pw");
        }

        [TestCleanup]
        public void TeardownTest()
        {
            fb.Quit();
            github.Quit();
            gmail.Quit();
            packtpub.Quit();
        }
    }
}
