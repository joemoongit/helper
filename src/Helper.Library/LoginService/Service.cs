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
        public static BrowserV2 Login(BrowserV2 browser, LoginElements loginElements)
        {
            loginElements.LoginField.Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.PasswordField.Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.LoginButton.Click();
            return browser;
        }

        public static BrowserV2 LoginWithWait(BrowserV2 browser, LoginElements loginElements)       //for ATT
        {
            WebDriver.WaitUntilElementIsVisible(browser.webDriver(), loginElements.By1, 5).Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.PasswordField.Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.LoginButton.Click();
            return browser;
        }

        public static BrowserV3 LoginGoogle(BrowserV3 browser, GoogleLoginElements loginElements)
        {
            loginElements.LoginField.Click();
            loginElements.LoginField.SendKeys(browser.UserId);
            loginElements.LoginButton.Click();
            WebDriver.WaitUntilElementIsVisible(browser.webDriver, loginElements.By2, 5).Click();
            loginElements.PasswordField.SendKeys(browser.Password);
            loginElements.PasswordNextButton.Click();
            return browser;
        }

        //WIP
        public static BrowserV2 PullStatement(BrowserV2 browser)
        {
            return browser;
        }

        public static BrowserV2 SchedulePayment(BrowserV2 browser)
        {
            return browser;
        }
    }
}
