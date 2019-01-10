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
