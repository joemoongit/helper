using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Library;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class WellsFargo : Browser
    {   
        //WIP
        public WellsFargo()
        {
            Settings = new WellsFargoSettings();
            Initalize();
            NavigateTo(Url);
            //NavigateTo("https://connect.secure.wellsfargo.com/auth/login/present?origin=cob&error=yes&LOB=CONS&destination=AccountSummary");
        }

        public WellsFargo LoginOld(string userId, string password)
        {
            LoginField.Click();
            LoginField.SendKeys(userId);
            PasswordField.Click();
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        public WellsFargo LoginAgain(string userId, string password)
        {
            LoginField2.Click();
            LoginField2.SendKeys(userId);
            PasswordField2.Click();
            PasswordField2.SendKeys(password);
            LoginButton2.Click();
            return this;
        }

        public WellsFargo Login()
        {
            var Elements = new WellsFargoLoginElements();
            Service.Login(this, Elements);
            return this;
        }

        public IWebElement LoginField => Driver.FindElement(By.Id("userid"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => Driver.FindElement(By.Id("btnSignon"));

        public IWebElement LoginField2 => Driver.FindElement(By.Id("j_username"));
        public IWebElement PasswordField2 => Driver.FindElement(By.Id("j_password"));
        //public IWebElement LoginButton2 => Driver.FindElement(By.Id("submit"));
        public IWebElement LoginButton2 => Driver.FindElement(By.CssSelector("#Signon > section.antiClickjackContent > div.block-display.clear-both > input"));
    }

    public class WellsFargoLoginElements : LoginElements
    {
        public WellsFargoLoginElements()
        {
            By1 = By.Id("userid");
            By2 = By.Id("password");
            By3 = By.Id("btnSignon");
        }
    }
}
