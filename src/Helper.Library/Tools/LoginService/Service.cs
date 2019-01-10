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

        public static Browser LoginWithWait(Browser browser, LoginElements loginElements)       //for ATT login page
        {
            WebDriver.WaitUntilElementIsVisible(browser.webDriver, loginElements.By1, 5).Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.PasswordField.Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.LoginButton.Click();
            return browser;
        }

        public static Browser LoginGoogle(Browser browser, LoginElementsV2 loginElements)
        {
            loginElements.LoginField.Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.Next.Click();
            WebDriver.WaitUntilElementIsVisible(browser.webDriver, loginElements.By3, 5).Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.LoginButton.Click();
            return browser;
        }

        //WIP
        public static Browser PullStatement(Browser browser)
        {
            return browser;
        }

        public static Browser SchedulePayment(Browser browser)
        {
            return browser;
        }
    }
}
