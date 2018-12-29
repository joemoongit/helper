using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class FbPhotoScript
    {
        protected Facebook fb;
        protected FbProfilePage navbar;

        [TestInitialize]
        public void SetupTest()
        {
            fb = new Facebook();
            navbar = new FbProfilePage(fb);
        }

        [TestMethod]
        public void TestMethod1()
        {
            navbar.SavePhotos();
            //fb.ClickNavbar();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            navbar.Quit();
            //fb.Quit();
        }
    }
}
