using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.BankSites
{
    [TestClass]
    public class CitiScript
    {
        protected Citi citi;

        [TestInitialize]
        public void SetupTest()
        {
            citi = new Citi();
        }

        [TestMethod]
        public void TestMethod1()
        {
            citi.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            citi.Quit();
        }
    }
}
