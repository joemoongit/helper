using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public class N1Child1 : BasePage
    {
        public N1Child1(LoginPage loginPage)
        {
            loginPage.Navbar1.Click();
            Child1WebElement.Click();
        }

        public void PostToPage()
        {
            SomeField.Click();
            SomeField.SendKeys("some string");

        }


        public IWebElement Child1WebElement => WebDriver.Driver.FindElement(By.LinkText("Child1"));

        public IWebElement SomeField => WebDriver.Driver.FindElement(By.CssSelector("#someField"));
        public IWebElement SomeButton => WebDriver.Driver.FindElement(By.CssSelector("#someButton"));


    }
}
