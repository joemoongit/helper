using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public static class WebElement 
    {
        public static IList<IWebElement> SomeElementList(IWebDriver driver, string someString)
        {
            switch (someString.ToLower())
            {
                case "allmultieselectitems":
                    return driver.FindElements(By.ClassName("k-item"));
                case "allgriditems":
                    return driver.FindElements(By.TagName("td"));
                    
            }
            return driver.FindElements(By.TagName("some default element list"));
        }


        //public IList<IWebElement> AllMultiSelectItems => WebDriver.Driver.FindElements(By.ClassName("k-item"));

        //public IList<IWebElement> AllGridItems => WebDriver.Driver.FindElements(By.TagName("td"));
    }
}
