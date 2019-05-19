using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.hcc;

namespace Helper.Scripts.HccScripts
{
    [TestClass]
    public class ChambermasterScript
    {
        protected Chambermaster cm;

        [TestInitialize]
        public void SetupTest()
        {
            cm = new Chambermaster();
        }

        [TestMethod]
        public void LoginForNow()
        {
            cm.Login();
            cm.Invoices();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            cm.Quit();
        }
    }
}
