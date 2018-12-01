using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Helper.Library
{
    public class BasePage : Utility
    {
        protected Settings Settings;

        public BasePage Quit()
        {
            WebDriver.Driver.Quit();
            return this;
        }

        public BasePage Close()
        {
            WebDriver.Driver.Close();
            return this;
        }

        public BasePage NavigateTo(string url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
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
            ((IJavaScriptExecutor)WebDriver.Driver).ExecuteScript("window.open()");
            List<string> tabs = new List<string>(WebDriver.Driver.WindowHandles);
            System.Diagnostics.Debug.WriteLine(tabs);
            WebDriver.Driver.SwitchTo().Window(tabs[1]);
            WebDriver.Driver.Navigate().GoToUrl(url);
            return this;
        }

        public BasePage SwitchTab<T> (T index)
        {
            List<string> tabs = new List<string>(WebDriver.Driver.WindowHandles);
            WebDriver.Driver.SwitchTo().Window(tabs[Int32.Parse(index.ToString())]);
            return this;
        }

        public BasePage TakeScreenshot()
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
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
            WebDriver.Driver.Navigate().GoToUrl(urlBuilder.ReturnUrl());
            return this;
        }

        public IList<IWebElement> AllMultiSelectItems => WebDriver.Driver.FindElements(By.ClassName("k-item"));
        public IList<IWebElement> AllGridItems => WebDriver.Driver.FindElements(By.TagName("td"));

        public IWebElement PostVerificationAlertButton => WebDriver.Driver.FindElement(By.CssSelector("#wrapper > div.navbar-default.yamm.ins-navbar > div > div > div:nth-child{2} > ul > li:nth-child(@) > ins-distribute-all > div"));
        public IWebElement ToasterPopup => WebDriver.Driver.FindElement(By.CssSelector("#toast-container > div"));
        public IWebElement SecondToasterPopup => WebDriver.Driver.FindElement(By.CssSelector("#toast-container > div:nth-child(2)"));
    }
}
