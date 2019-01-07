using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Linkedin : Browser
    {
        public Linkedin()
        {
            Settings = new LinkedinSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Linkedin Login()
        {
            var Elements = new LinkedinLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class LinkedinSettings : ISettings
    {
        public string Url => "https://www.linkedin.com/";
        public string UserId => "";
        public string Password => "";
    }

    public class LinkedinLoginElements : LoginElements
    {
        public LinkedinLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"login-email\"]");
            By2 = By.XPath("//*[@id=\"login-password\"]");
            By3 = By.XPath("//*[@id=\"login-submit\"]");
        }
    }
}
