using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class GmailScript
    {
        protected Gmail g;

        [TestInitialize]
        public void SetupTest()
        {
            g = new Gmail().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            g.MarkEmailsAsRead();
            g.LocateAllEmails();
        }

        protected GmailAccountSettings gmailAccountSettings;
        [TestMethod]
        public void TestMethod2()
        {
            gmailAccountSettings = new GmailAccountSettings(g);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            g.Quit();
        }
    }
}
