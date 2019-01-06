using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Walmart : Browser
    {
        public Walmart()
        {
            Settings = new WalmartSettings();
            Initalize();
            NavigateTo(Url);
        }
    }

    public class WalmartLoginElements : LoginElements
    {
        public WalmartLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"email\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"sign-in-form\"]/button[1]");
        }
    }
}
