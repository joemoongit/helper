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
        public static IWebDriver Driver()
        {
            switch (ConfigurationManager.AppSettings["driver"].ToLower())
            {
                case "c":
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--disable-notifications");
                    return new ChromeDriver(options);
                case "f":
                case "ff":
                case "firefox":
                    return new FirefoxDriver();
                case "ie":
                    return new InternetExplorerDriver(); 
                case "edge":
                    return new EdgeDriver();
                case "opera":
                    return new OperaDriver();
                case "safari":
                    return new SafariDriver();
            }
            return new ChromeDriver();
        }

        public static IWebElement FindElement(IWebDriver driver, By by, int timeoutInSeconds = 0)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static IReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, By by, int timeoutInSeconds = 0)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
            }
            return driver.FindElements(by);
        }

        public static IWebElement WaitUntilElementIsVisible(IWebDriver driver, By by, int timeoutInSeconds = 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
