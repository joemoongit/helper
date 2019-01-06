using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Ebay : Browser
    {
        public Ebay()
        {
            Settings = new EbaySettings();
            Initalize();
            NavigateTo(Url);
        }

        public Ebay Login()
        {
            var Elements = new EbayLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class EbayLoginElements : LoginElements
    {
        public EbayLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"userid\"]");
            By2 = By.XPath("//*[@id=\"pass\"]");
            By3 = By.XPath("//*[@id=\"sgnBt\"]");
        }
    }
}
