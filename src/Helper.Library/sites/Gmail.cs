using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.sites
{
    public class Gmail : Browser
    {
        public Gmail()
        {
            NavigateTo("https://gmail.com");
        }

        public Gmail Login(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            LoginFieldNext.Click();
            Driver.WaitUntilElementIsVisible(By.CssSelector("input[type='password']"), 5);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            PasswordFieldNext.Click();
            return this;
        }




        public IWebElement LoginField => Driver.FindElement(By.Id("identifierId"));
        public IWebElement LoginFieldNext => Driver.FindElement(By.Id("identifierNext"));
        //public IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        public IWebElement PasswordField => Driver.FindElement(By.CssSelector("input[type='password']"));
        public IWebElement PasswordFieldNext => Driver.FindElement(By.Id("passwordNext"));
    }
}
