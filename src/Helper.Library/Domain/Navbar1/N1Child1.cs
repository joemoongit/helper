using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Domain
{
    public class N1Child1 : Browser
    {
        public N1Child1(Library.LoginPageOld loginPage)
        {
            loginPage.Navbar1.Click();
            N1Child1WebElement.Click();
        }

        public void PostToPage()
        {
            SomeField.Click();
            SomeField.SendKeys("some string");

        }


        public IWebElement N1Child1WebElement => Driver.FindElement(By.LinkText("Child1"));

        public IWebElement SomeField => Driver.FindElement(By.CssSelector("#someField"));
        public IWebElement SomeButton => Driver.FindElement(By.CssSelector("#someButton"));


    }
}
