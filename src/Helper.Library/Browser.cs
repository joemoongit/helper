using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Helper.Library
{
    public class Browser
    {
        protected Settings Settings;
        protected IWebDriver Driver;

        public Browser()
        {
            Driver = WebDriver.Initialize();
        }

        public Browser NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public Browser Close()
        {
            Driver.Close();
            return this;
        }

        public Browser Quit()
        {
            Driver.Quit();
            return this;
        }

        public Browser ConfigureLoginSettings(string userId = null, string password = null, string org = null)     //needed?
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
        public Browser OpenNewTab(string url)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            Driver.SwitchTo().Window(tabs[1]);
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public Browser SwitchTab<T> (T index)
        {
            List<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[Int32.Parse(index.ToString())]);
            return this;
        }

        public Browser TakeScreenshot()
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

        public Browser DuplicatePage()
        {
            var urlBuilder = new UrlBuilder(Settings);
            Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }


        public IWebElement PostVerificationAlertButton => Driver.FindElement(By.CssSelector("#wrapper > div.navbar-default.yamm.ins-navbar > div > div > div:nth-child{2} > ul > li:nth-child(@) > ins-distribute-all > div"));
        public IWebElement ToasterPopup => Driver.FindElement(By.CssSelector("#toast-container > div"));
        public IWebElement SecondToasterPopup => Driver.FindElement(By.CssSelector("#toast-container > div:nth-child(2)"));
    }
}
