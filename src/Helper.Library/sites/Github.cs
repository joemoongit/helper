using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.sites
{
    public class Github : Browser
    {
        public Github()
        {
            NavigateTo("https://github.com/login");
        }

        public Github Login(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        public IWebElement LoginField => Driver.FindElement(By.Id("login_field"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("#login > form > div.auth-form-body.mt-3 > input.btn.btn-primary.btn-block"));
    }
}
