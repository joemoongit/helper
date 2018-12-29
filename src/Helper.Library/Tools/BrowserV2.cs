using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public abstract class BrowserV2
    {
        protected ISettings Settings;
        protected IWebDriver Driver;

        public BrowserV2 Initalize()
        {
            Driver = WebDriver.Driver();
            return this;
        }

        public BrowserV2 NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BrowserV2 Close()
        {
            Driver.Close();
            return this;
        }

        public BrowserV2 Quit()
        {
            Driver.Quit();
            return this;
        }

        public IWebDriver webDriver()
        {
            return Driver;
        }

        public string Url
        {
            get => Settings.Url;
        }

        public string UserId
        {
            get => Settings.UserId;
        }

        public string Password
        {
            get => Settings.Password;
        }

        public BrowserV2 OpenNewTab(string url = null)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            Driver.SwitchTo().Window(tabs[tabs.Count - 1]);
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BrowserV2 SwitchTab<T>(T index)
        {
            List<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[Int32.Parse(index.ToString())]);
            return this;
        }

        public BrowserV2 TakeScreenshot()
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

        public BrowserV2 DuplicatePage()
        {
            //var urlBuilder = new UrlBuilder(Settings);
            //Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }
    }
}
