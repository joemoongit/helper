using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Slickdeals : Browser
    {
        public Slickdeals()
        {
            Settings = new SlickdealsSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Slickdeals Login()
        {
            var Elements = new SlickdealsLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class SlickdealsLoginElements : LoginElements
    {
        public SlickdealsLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"email\"]");
            By2 = By.XPath("//*[@id=\"passwordInput\"]");
            By3 = By.XPath("//*[@id=\"loginform\"]/input[11]");
        }
    }
}
