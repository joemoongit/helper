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
            github.Login();
            fb.Login();
            gmail.Login();
            packtpub.Login();
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
