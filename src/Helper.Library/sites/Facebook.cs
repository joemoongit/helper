using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;      //temporary

namespace Helper.Library.sites
{
    public class Facebook : Browser
    {
        public Facebook()
        {
            NavigateTo("https://fb.com");
        }

        public Facebook Login(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        public Facebook NavigateTo()
        {
            return this;
        }


        public IWebElement LoginField => Driver.FindElement(By.Id("email"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("pass"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("loginbutton"));

    }
}
