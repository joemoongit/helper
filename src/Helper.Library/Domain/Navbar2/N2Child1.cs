using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Domain
{
    public class N2Child1 : Browser
    {
        public N2Child1(Library.LoginPageOld loginPage)
        {
            loginPage.Navbar2.Click();
            Child1WebElement.Click();
        }

        public N2Child1 ReturnGridElements(string name)
        {
            int gridcellIndex = 0;
            string temporaryString = "";
            Dictionary<string, IWebElement> Dictionary = new Dictionary<string, IWebElement> { };

            foreach (var item in WebDriver.FindElements(Driver, By.TagName("td")))
            {
                if (Utility.IndexOfGrid(gridcellIndex, 10) == 1)
                {
                    temporaryString = item.Text;
                }
                else if (Utility.IndexOfGrid(gridcellIndex, 10) == 9)
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
