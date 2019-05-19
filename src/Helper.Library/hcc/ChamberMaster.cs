using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Helper.Library.hcc
{
    public class Chambermaster : Browser
    {
        public Chambermaster()
        {
            Initalize();
            Settings = new ChambermasterSettings();
            NavigateTo(Url);
        }

        public Chambermaster Login()
        {
            var Elements = new ChambermasterLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }

        public Chambermaster Invoices()
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.Id("leftnav7"), 5).Click();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"divMenu\"]/table/tbody/tr/td[2]/div[1]/div/ul/li[2]"), 5).Click();
            return this;
        }
    }

    public class ChambermasterLoginElements : LoginElements
    {
        public ChambermasterLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.Id("UserName");
            By2 = By.Id("Password");
            By3 = By.Name("Submit");
        }
    }
}
