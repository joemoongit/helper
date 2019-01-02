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
        public By By1;
        public By By2;
        public By By3;

        public IWebDriver Driver
        {
            get;
            set;
        }

        public IWebElement LoginField
        {
            get => Driver.FindElement(By1);
        }

        public IWebElement PasswordField
        {
            get => Driver.FindElement(By2);
        }

        public IWebElement LoginButton
        {
            get => Driver.FindElement(By3);
        }
    }
}
 