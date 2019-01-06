using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Paychex : Browser
    {
        public Paychex()
        {
            Settings = new PaychexSettings();
            Initalize();
            NavigateTo(Url);
        }
    }

    public class PaychexLoginElements : LoginElements
    {
        public PaychexLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("");
            By2 = By.XPath("");
            By3 = By.XPath("");
        }
    }
}
