using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;

namespace Helper.Library
{
    public class LoginPage : Browser
    {
        public LoginPage(string userId = null, string password = null)
        {
            WebDriver.Initialize();
            NavigateTo(Settings.EnvSettings.UrlPrefix + ".josephmoon.com/Login");
            if (userId == null && password == null)
            {
                LoginAs(Settings.LoginSettings.UserId + "@" + Settings.EnvSettings.OrgPrefix + Settings.LoginSettings.Org + ".com", Settings.LoginSettings.Password + Settings.EnvSettings.PasswordSuffix);
            }
            else if (userId == null || password == null)
            {
                Debug.WriteLine("Login Failed");
            }
            else
            {
                LoginAs(userId, password);
            }
        }

        public LoginPage LoginAs(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        public Settings ReturnSettings()
        {
            return Settings;
        }

        // login page elements
        public IWebElement LoginField => Driver.FindElement(By.Id("login"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("login-btn"));

        public IWebElement CompanyLogo => Driver.FindElement(By.Id("company-logo"));
        public IWebElement Recaptcha => Driver.FindElement(By.Id("reCaptcha"));
        public IWebElement LoginFailMessage => Driver.FindElement(By.TagName("li"));
        public IWebElement RememberMeButton => Driver.FindElement(By.Id("rememberme-checkbox"));
        public IWebElement ForgotPasswordLink => Driver.FindElement(By.Id("forgot-password-link"));

        // navbar elements
        public IWebElement Navbar1 => Driver.FindElement(By.CssSelector("#navbar1"));
        public IWebElement Navbar2 => Driver.FindElement(By.CssSelector("#navbar2"));
    }
}
