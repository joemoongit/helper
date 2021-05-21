using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using Helper.Library.Sites;
using OpenQA.Selenium;

namespace Helper.Library
{
    public static class Service
    {
        public static Browser Login(Browser browser, LoginElements loginElements)
        {
            loginElements.LoginField.Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.PasswordField.Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.LoginButton.Click();
            return browser;
        }
    }
}
