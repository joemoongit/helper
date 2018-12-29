using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library
{
    public abstract class BrowserV3
    {
        protected ISettingsV2 Settings;
        protected IWebDriver Driver;

        public BrowserV3 Initalize()
        {
            Driver = WebDriver.Driver();
            return this;
        }

        public BrowserV3 NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BrowserV3 Close()
        {
            Driver.Close();
            return this;
        }

        public BrowserV3 Quit()
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
            set => Settings.Password = value;
        }

        public string Password
        {
            get => Settings.Password;
            set => Settings.Password = value;
        }

        public BrowserV3 OpenNewTab(string url = null)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            Driver.SwitchTo().Window(tabs[tabs.Count - 1]);
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BrowserV3 SwitchTab<T>(T index)
        {
            List<string> tabs = new List<string>(Driver.WindowHandles);
            Driver.SwitchTo().Window(tabs[Int32.Parse(index.ToString())]);
            return this;
        }

        public BrowserV3 TakeScreenshot()
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

        public BrowserV3 DuplicatePage()
        {
            //var urlBuilder = new UrlBuilder(Settings);
            //Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }
    }
}
