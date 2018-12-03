using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Domain
{
    public class N1Child2 : Browser
    {
        public N1Child2(Library.LoginPageOld loginPage)
        {
            loginPage.Navbar1.Click();
            Child2WebElement.Click();
        }



        public IWebElement Child2WebElement => Driver.FindElement(By.LinkText("Child2"));
    }
}
