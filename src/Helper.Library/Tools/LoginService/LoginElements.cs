using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public interface ILoginElements
    {
        IWebDriver Driver { get; set; }
        IWebElement LoginField { get; }
        IWebElement PasswordField { get; }
        IWebElement LoginButton { get; }
    }

    public abstract class LoginElements : ILoginElements
    {
        public By By1;          // login field
        public By By2;          // password field
        public By By3;          // login button

        public IWebDriver Driver
        {
            get;
            set;
        }
        public IWebElement LoginField => Driver.FindElement(By1);
        public IWebElement PasswordField => Driver.FindElement(By2);
        public IWebElement LoginButton => Driver.FindElement(By3);
    }

    public interface ILoginElementsV2
    {
        IWebDriver Driver { get; set; }
        IWebElement LoginField { get; }
        IWebElement Next { get; }
        IWebElement PasswordField { get; }
        IWebElement LoginButton { get; }
    }

    public abstract class LoginElementsV2 : ILoginElementsV2
    {
        public By By1;          // login field
        public By By2;          // next
        public By By3;          // password field
        public By By4;          // login button

        public IWebDriver Driver
        {
            get;
            set;
        }
        public IWebElement LoginField => Driver.FindElement(By1);
        public IWebElement Next => Driver.FindElement(By2);
        public IWebElement PasswordField => Driver.FindElement(By3);
        public IWebElement LoginButton => Driver.FindElement(By4);
    }
}
 