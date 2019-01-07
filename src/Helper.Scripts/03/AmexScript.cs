﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts.BankSites
{
    [TestClass]
    public class AmexScript
    {
        protected Amex a;
        
        [TestInitialize]
        public void SetupTest()
        {
            a = new Amex();
        }

        [TestMethod]
        public void TestMethod1()
        {
            a.Login();
        }

        [TestMethod]
        public void TestExpFeatures()
        {
            var PullStatements = new AmexExpFeatures(a).PullStatements();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            a.Quit();
        }
    }
}
  