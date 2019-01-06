using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Citi : Browser
    {
        public Citi()
        {
            Settings = new CitiSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Citi LoginV2()
        {
            var Elements = new CitiLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }

        public Citi Login()
        {
            var Elements = new CitiLoginElements(Driver);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Elements.LoginField);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].sendKeys(\"josephmoon817\");", Elements.LoginField);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Elements.PasswordField);
            Elements.PasswordField.SendKeys(Password);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Elements.LoginButton);
            return this;
        }
    }

    public class CitiLoginElements : LoginElements
    {
        public CitiLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"signInBtn\"]");
        }
    }
}
