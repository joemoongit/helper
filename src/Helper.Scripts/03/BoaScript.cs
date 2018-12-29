using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.BankSites
{
    [TestClass]
    public class BoaScript
    {
        protected Boa b;

        [TestInitialize]
        public void SetupTest()
        {
            b = new Boa();
        }

        [TestMethod]
        public void TestMethod1()
        {
            b.Login();
            //b.PullStatements();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            b.Quit();
        }
    }
}
