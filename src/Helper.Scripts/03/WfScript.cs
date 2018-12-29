using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.BankSites
{
    [TestClass]
    public class WfScript
    {
        protected WellsFargo wf;

        [TestInitialize]
        public void SetupTest() 
        {
            wf = new WellsFargo();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //wf.Login("id", "pw");
            //wf.LoginAgain("id", "pw");
            wf.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
           wf.Quit();
        }
    }
}
