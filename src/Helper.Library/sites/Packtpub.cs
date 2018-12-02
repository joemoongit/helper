using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.sites
{
    public class Packtpub : Browser
    {
        public Packtpub()
        {
            NavigateTo("https://www.packtpub.com/login");
        }

        public Packtpub Login(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", LoginButton);
            return this;
        }
 
        public IWebElement LoginField => Driver.FindElement(By.Id("edit-name"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("edit-pass"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("edit-post-form"));
    }
}
