using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using System.Configuration;

namespace Helper.Library
{
    public class BasePage : Utility
    {
        protected IWebDriver Driver;
        protected Settings Settings;

        public void Initalize()
        {
            switch (ConfigurationManager.AppSettings["driver"].ToLower())
            {
                case "chrome":
                    this.Driver = new ChromeDriver();
                    break;
                case "firefox":
                    this.Driver = new FirefoxDriver();
                    break;
                case "ie":
                    this.Driver = new InternetExplorerDriver();
                    break;
                case "edge":
                    this.Driver = new EdgeDriver();
                    break;
                case "opera":
                    this.Driver = new OperaDriver();
                    break;
                case "safari":
                    this.Driver = new SafariDriver();
                    break;
            }
        }


        public BasePage Quit()
        {
            Driver.Quit();
            return this;
        }


        public BasePage NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }




        public BasePage ConfigureLoginSettings(string userId = null, string password = null, string org = null)
        {
            if (userId != null)
            {
                Settings.LoginSettings.UserId = userId;
            }
            else if (password != null)
            {
                Settings.LoginSettings.Password = password;
            }
            else if (org != null)
            {
                Settings.LoginSettings.Org = org;
            }
            return this;
        }

        //WIP
        public BasePage OpenNewTab(string url)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            Driver.SwitchTo().Window(tabs[1]);
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BasePage SwitchTab(string index)
        {
            List<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[Int32.Parse(index)]);
            return this;
        }

        public BasePage SwitchTabV2<T> (T index)
        {
            List<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[Int32.Parse(index.ToString())]);
            return this;
        }

        public BasePage TakeScreenshot()
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                ss.SaveAsFile(@"..\..\..\..\Screenshots\SeleniumScreenshotTest_" + $"{DateTime.Now: yyyy-MM-dd_hh-mm-ss-fff}" + ".jpg", ScreenshotImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return this;
        }

        public BasePage DuplicatePage()
        {
            var urlBuilder = new UrlBuilder(Settings);
            Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }

        public IList<IWebElement> AllMultiSelectItems => Driver.FindElements(By.ClassName("k-item"));
        public IList<IWebElement> AllGridItems => Driver.FindElements(By.TagName("td"));

        public IWebElement PostVerificationAlertButton => Driver.FindElement(By.CssSelector("#wrapper > div.navbar-default.yamm.ins-navbar > div > div > div:nth-child{2} > ul > li:nth-child(@) > ins-distribute-all > div"));
        public IWebElement ToasterPopup => Driver.FindElement(By.CssSelector("#toast-container > div"));
        public IWebElement SecondToasterPopup => Driver.FindElement(By.CssSelector("#toast-container > div:nth-child(2)"));
    }
}
