using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Starbucks : Browser
    {
        public Starbucks()
        {
            Settings = new StarbucksSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Starbucks Login()
        {
            var Elements = new StarbucksLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class StarbucksLoginElements : LoginElements
    {
        public StarbucksLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"content\"]/div[2]/div/div/div/div/div[1]/form/div[4]/div/span/div/button");
        }
    }
}
