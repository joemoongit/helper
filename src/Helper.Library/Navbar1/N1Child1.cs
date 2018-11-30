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
            Driver = loginPage.WebDriver();
            loginPage.Navbar1.Click();
            Child1WebElement.Click();
        }

        public void PostToPage()
        {
            SomeField.Click();
            SomeField.SendKeys("some string");

        }


        public IWebElement Child1WebElement => Driver.FindElement(By.LinkText("Child1"));

        public IWebElement SomeField => Driver.FindElement(By.CssSelector("#someField"));
        public IWebElement SomeButton => Driver.FindElement(By.CssSelector("#someButton"));


    }
}
