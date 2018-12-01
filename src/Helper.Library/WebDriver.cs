using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;


namespace Helper.Library
{
    public static class WebDriver
    {
        public static IWebDriver Driver;

        public static void Initialize()
        {
            switch (ConfigurationManager.AppSettings["driver"].ToLower())
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "ie":
                    Driver = new InternetExplorerDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
                case "opera":
                    Driver = new OperaDriver();
                    break;
                case "safari":
                    Driver = new SafariDriver();
                    break;
            }
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static IReadOnlyCollection<IWebElement> FindElements(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
            }
            return driver.FindElements(by);
        }

        public static IWebElement WaitUntilElementIsVisible(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
