using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Att : Browser
    {
        public Att()
        {
            Settings = new AttSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Att Login()
        {
            var Elements = new AttLoginElements(Driver);
            Service.LoginWithWait(this, Elements);
            return this;
        }
    }

    public class AttLoginElements : LoginElements
    {
        public AttLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"userName\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"loginButton-lgwgLoginButton\"]");
        }
    }
}
