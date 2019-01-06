using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Helper.Library.Sites
{
    public class Boa : Browser
    {
        public Boa()
        {
            Settings = new BoaSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Boa Login()
        {
            var Elements = new BoaLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }

        public Boa ViewLastStatement()
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"a_cardAcctStatement_9223e75670eced5d1ddc35916d17b3213b407c13e287a9f4087ccb40c5a703bf\"]"), 5).Click();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"custmt-widget-9223e75670eced5d1ddc35916d17b3213b407c13e287a9f4087ccb40c5a703bf\"]/div/div/div[1]/div[1]/a"), 5).Click();
            return this;
        }
    }

    public class BoaStatementAndDocuments : Browser
    {
        public BoaStatementAndDocuments(Boa b)
        {
            Driver = b.webDriver;
            var action = new Actions(Driver);
            action.MoveToElement(WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"fsd-li-accounts\"]/a"), 5)).Build().Perform();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"fsd-li-accounts\"]/div/div[1]/div[1]/div[2]/a[1]"), 5).Click();
        }

        public BoaStatementAndDocuments ToggleYear<T>(T year)
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"yearDropDown\"]"), 5).Click();
            Driver.FindElement(By.XPath("//*[@value=" + year.ToString() + "]")).Click();
            return this;
        }

        public BoaStatementAndDocuments ViewStatement(string month)                      //(params string[] months)
        {
            Driver.FindElement(By.XPath("//*[@id=\"ecc-accordionPanel0\"]/a/span[2]")).Click();
            //var statements = WebDriver.FindElements(Driver, By.TagName("b"), 5).Where(statement => statement.Text != "").ToList();
            var statements = Driver.FindElements(By.TagName("b")).Where(statement => statement.Text != "").ToList();


            Dictionary<string, IWebElement> StatementDictionary = new Dictionary<string, IWebElement> { };
            foreach (var statement in statements)
            {
                StatementDictionary[statement.Text.ToLower()] = statement;
            }
            StatementDictionary[month.ToLower() + " statement"].Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//*[@id=\"viewPDFAccLink\"]")));               // //*[@id="downloadPDFAccLink"]
            return this;
        }

    }

    public class BoaLoginElements : LoginElements
    {
        public BoaLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"onlineId1\"]");
            By2 = By.XPath("//*[@id=\"passcode1\"]");
            By3 = By.XPath("//*[@id=\"signIn\"]/span[1]");
        }
    }
}
