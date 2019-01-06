using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Amazon : Browser
    {
        public Amazon()
        {
            Settings = new AmazonSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Amazon Login()
        {
            var Elements = new AmazonLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class AmazonLoginElements : LoginElements
    {
        public AmazonLoginElements(IWebDriver driver)
        {
            Driver = Driver;
            By1 = By.XPath("//*[@id=\"ap_email\"]");
            By2 = By.XPath("//*[@id=\"ap_password\"]");
            By3 = By.XPath("//*[@id=\"signInSubmit\"]");
        }
    }
}
