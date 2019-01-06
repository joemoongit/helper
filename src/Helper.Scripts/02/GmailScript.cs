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

        [TestMethod]
        public void TestGmailLogin()
        {
            var gmail2 = new Gmail("anotherUserId", "anotherPw").Login();
            gmail2.Quit();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            gmail.Quit();
        }
    }
}
 