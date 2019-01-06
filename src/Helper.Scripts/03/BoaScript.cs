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
            b = new Boa().Login();
        }

        [TestMethod]
        public void TestMethod1()
        {
            b.ViewLastStatement();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var bb = new BoaStatementAndDocuments(b);
            bb.ToggleYear(2018);
            bb.ViewStatement("april");
        }

        [TestCleanup]
        public void TeardownTest()
        {
            b.Quit();
        }
    }
}
