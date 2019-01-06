using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Walgreens : Browser
    {
        public Walgreens()
        {
            Settings = new WalgreensSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Walgreens Login()
        {
            var Elements = new WalgreensLoginElements(Driver);
            Service.LoginGoogle(this, Elements);
            return this;
        }
    }

    public class WalgreensLoginElements : LoginElementsV2
    {
        public WalgreensLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"userName-phoneNo\"]");
            By2 = By.XPath("//*[@id=\"continueBtn\"]");
            By3 = By.XPath("//*[@id=\"password\"]");
            By4 = By.XPath("//*[@id=\"passwordtabSignIn\"]");
        }
    }
}
