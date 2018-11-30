using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public class N2Child2 : BasePage
    {
        public N2Child2(LoginPage loginPage)
        {
            Driver = loginPage.WebDriver();
            loginPage.Navbar1.Click();
            Child2WebElement.Click();
        }

        public IWebElement Child2WebElement => Driver.FindElement(By.LinkText("Child2"));
    }
}
