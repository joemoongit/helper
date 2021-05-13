using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class LoginScript
    {
        protected Github github;

        [TestInitialize]
        public void SetupTest()
        {
            github = new Github();
        }

        [TestMethod]
        public void TestSites()
        {
            github.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            github.Quit();
        }
    }
}
