using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Hulu :  Browser
    {
        public Hulu()
        {
            Settings = new HuluSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Hulu Login()
        {
            var Elements = new HuluLoginElements(Driver);
            Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/div/div[1]/header/div[1]/div[2]/div[2]/a")).Click();     //login button on home page
            Service.Login(this, Elements);
            return this;
        }
    }

    public class HuluLoginElements : LoginElements
    {
        public HuluLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"login-modal\"]/div[2]/div[2]/div/div/div[1]/div[2]/div[3]/input[1]");
            By2 = By.XPath("//*[@id=\"login-modal\"]/div[2]/div[2]/div/div/div[1]/div[2]/div[3]/input[2]");
            By3 = By.XPath("//*[@id=\"login-modal\"]/div[2]/div[2]/div/div/div[1]/div[2]/div[3]/button");
        }
    }
}
