using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper.Library.Sites;

namespace Helper.Scripts
{
    [TestClass]
    public class FbPhotoScript
    {
        protected Facebook fb;
        protected FacebookProfilePage navbar;

        [TestInitialize]
        public void SetupTest()
        {
            fb = new Facebook();
            navbar = new FacebookProfilePage(fb);
        }
 
        [TestMethod]
        public void TestMethod1()
        {
            navbar.SavePhotos();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            navbar.Quit();
        }
    }
}
