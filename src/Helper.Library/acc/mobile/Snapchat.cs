using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Snapchat : Browser
    {
        public Snapchat()
        {
            Settings = new SnapchatSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Snapchat Login()
        {
            var Elements = new SnapchatLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class SnapchatLoginElements : LoginElements
    {
        public SnapchatLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"login_form\"]/div[4]/button");
        }
    }
}
