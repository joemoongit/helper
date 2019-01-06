using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Toyota : Browser
    {
        public Toyota(Browser browser = null)
        {
            Settings = new ToyotaSettings();
            Initalize();
            NavigateTo(Url);
        }
        
        public Toyota Login()
        {
            var Elements = new ToyotaLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class ToyotaLoginElements : LoginElements
    {
        public ToyotaLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"pwd\"]");
            By3 = By.XPath("/html/body/main/div/div/div[2]/div[2]/div[4]/form/div[5]/button");
        }
    }

}
