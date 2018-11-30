using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Navbar2
{
    public class N1Child1 : BasePage
    {
        public N1Child1(LoginPage loginPage)
        {
            Driver = loginPage.WebDriver();
            loginPage.Navbar2.Click();
            Child1WebElement.Click();
        }

        public N1Child1 ReturnGridElements(string name)
        {
            int gridcellIndex = 0;
            string temporaryString = "";
            Dictionary<string, IWebElement> Dictionary = new Dictionary<string, IWebElement> { };

            foreach(var item in AllGridItems)
            {
                if (IndexOfGrid(gridcellIndex, 10) == 1)        // || IndexOfGrid(gridcellIndex, 10) == 2
                {
                    temporaryString = item.Text;
                }
                else if (IndexOfGrid(gridcellIndex, 10) == 9)
                {
                    Dictionary[temporaryString] = item;
                }
                gridcellIndex++;
            }
            Dictionary[name].Click();
            return this;
        }

        public string ReturnUrlUsingEndpointName(string name)
        {
            //WIP
            return name;
        }

        public IWebElement Child1WebElement => Driver.FindElement(By.LinkText("Child1"));
    }
}
