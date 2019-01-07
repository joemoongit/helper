using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Indeed : Browser
    {
        public Indeed()
        {
            Settings = new IndeedSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Indeed Login()
        {
            var Elements = new IndeedLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class IndeedSettings : ISettings
    {
        public string Url => "https://secure.indeed.com/account/login?service=my&hl=en_US&co=US&continue=https%3A%2F%2Fwww.indeed.com%2F";
        public string UserId => "josephmoontutor@gmail.com";
        public string Password => "Sprite1234";
    }

    public class IndeedLoginElements : LoginElements
    {
        public IndeedLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"signin_email\"]");
            By2 = By.XPath("//*[@id=\"signin_password\"]");
            By3 = By.XPath("//*[@id=\"loginform\"]/button");
        }
    }
}
