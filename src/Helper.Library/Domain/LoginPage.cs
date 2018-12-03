using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Domain
{
    public class LoginPage : Browser
    {
        public LoginPage()
        {
            NavigateTo("https://www.domain.com");
        }

        public LoginPage Login(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        //login page elements
        public IWebElement LoginField => Driver.FindElement(By.Id("login"));
        public IWebElement LoginFieldWithWait => WebDriver.WaitUntilElementIsVisible(Driver, By.Id("login"), 5);
        public IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("login-button"));
        
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
