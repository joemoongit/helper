using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class YoutubeScript
    {
        protected Youtube y;

        [TestInitialize]
        public void SetupTest()
        {
            y = new Youtube();
        }


        [TestMethod]
        public void TestMethod1()
        {
            y.Login();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            y.Quit();
        }
    }
}
