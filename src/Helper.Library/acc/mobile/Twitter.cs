using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Twitter : Browser
    {
        public Twitter()
        {
            Settings = new TwitterSettings();
            Initalize();
            NavigateTo(Url);
        }
        
        public Twitter Login()
        {
            var Elements = new TwitterLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class TwitterLoginElements : LoginElements
    {
        public TwitterLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"page-container\"]/div/div[1]/form/fieldset/div[1]/input");
            By2 = By.XPath("//*[@id=\"page-container\"]/div/div[1]/form/fieldset/div[2]/input");
            By3 = By.XPath("//*[@id=\"page-container\"]/div/div[1]/form/div[2]/button");
        }
    }
}
