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
        protected ISettings Settings;
        protected IWebDriver Driver;

        public Browser Initalize()
        {
            Driver = WebDriver.Driver();
            return this;
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

        public IWebDriver webDriver
        {
            get => Driver;
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

        public Browser OpenNewTab(string url = null)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            Driver.SwitchTo().Window(tabs[tabs.Count - 1]);
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public Browser SwitchTab<T>(T index)
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
            //var urlBuilder = new UrlBuilder(Settings);
            //Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }
    }
}
