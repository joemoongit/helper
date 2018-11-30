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

        private Dictionary<string, string> PopulateDictionary(Dictionary<string, string> someDictionary)
        {
            foreach (var item in AllMultiSelectItems)
            {
                someDictionary[item.Text] = item.GetAttribute("data-offset-index");
            }
            return someDictionary;
        }

        public N2Child2 SelectItemInMultiSelectDropdown(params string[] items)
        {
            Dictionary<string, string> MultiSelectItemsDictionary = new Dictionary<string, string> { };
            MultiSelectField.Click();
            PopulateDictionary(MultiSelectItemsDictionary);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

            foreach (string item in items)
            {
                MultiSelectField.Click();
                jse.ExecuteScript("arguments[0].click();", MultiSelectItem(MultiSelectItemsDictionary[item]));
            }
            return this;
        }

        public IWebElement Child2WebElement => Driver.FindElement(By.LinkText("Child2"));

        public IWebElement MultiSelectField => Driver.FindElement(By.CssSelector("#templateForm > section:nth-child(2)"));
        public IWebElement MultiSelectItem(string itemIndex) => Driver.FindElement(By.CssSelector("#msMultiSelectItem_listbox > li:nth=child(" + (int.Parse(itemIndex) + 1).ToString() + ")"));
    }
}
