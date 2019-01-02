using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class GmailScript
    {
        protected Gmail gmail;

        [TestInitialize]
        public void SetupTest()
        {
            gmail = new Gmail().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            gmail.MarkEmailsAsRead();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var gmailAccountSettings = new GmailAccountSettings(gmail);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var g = new GmailExpFeatures(gmail);
            g.LocateAllEmails();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            gmail.Quit();
        }
    }
}
