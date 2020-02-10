using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Helper.Library.Registry;

namespace Helper.Library.Sites
{
    public class Gmail : Browser
    {
        public Gmail(string userId = null, string password = null)
        {
            Initalize();
            Settings = new GmailSettings();
            NavigateTo(Url);

            if (userId != null && password != null)
            {
                UserId = userId;
                Password = password;
            }
        }

        public Gmail Login()
        {
            var Elements = new GoogleLoginElements(Driver);
            Service.LoginGoogle(this, Elements);
            return this;
        }

        public Gmail MarkEmailsAsRead()
        {
            var SelectAllEmails = WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@role=\"button\"]/div[1]/span"), 10);
            var MarkAsRead = Driver.FindElement(By.CssSelector(@"#\3a 5 > div > div.nH.aqK > div.Cq.aqL > div > div > div:nth-child(3) > div.T-I.J-J5-Ji.m9.T-I-ax7.L3 > div"));
            SelectAllEmails.Click();
            MarkAsRead.Click();
            return this;
        }
    }

    public class GmailAccountSettings : Browser
    {
        public GmailAccountSettings(Gmail g)
        {
            Driver = g.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"gbwa\"]/div"), 5).Click();
            Driver.FindElement(By.XPath("//*[@id=\"gb192\"]")).Click();
        }
    }

    public class GoogleDrive : Browser
    {
        public GoogleDrive(Gmail g)
        {
            Driver = g.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"gbwa\"]/div/a/svg"), 5).Click();
            Driver.FindElement(By.XPath("//*[@id=\"gb49\"]/span[1]")).Click();
        }
    }

    public class GooglePhotos : Browser
    {
        public GooglePhotos()
        {

        }
    }

    public class GmailExpFeatures : Browser
    {
        public GmailExpFeatures(Gmail gmail)
        {
            Driver = gmail.webDriver;
        }

        public GmailExpFeatures LocateAllEmails()
        {
            var AllEmails = Driver.FindElements(By.TagName("tr")).Where(email => !string.IsNullOrEmpty(email.Text)).ToList();
            var AllPytorchEmails = Driver.FindElements(By.TagName("tr")).Where(email => email.Text.Contains("pytorch")).ToList();
            var AllOpenshiftEmails = Driver.FindElements(By.TagName("tr")).Where(email => email.Text.Contains("openshift")).ToList();
            System.Diagnostics.Debug.WriteLine(AllEmails.Count);
            foreach (var email in AllEmails)
            {
                System.Diagnostics.Debug.WriteLine(email.Text);
            }

            System.Diagnostics.Debug.WriteLine(AllPytorchEmails.Count);
            System.Diagnostics.Debug.WriteLine(AllOpenshiftEmails.Count);
            System.Diagnostics.Debug.WriteLine(FilterEmailUsingKeyword("pytorch").Count);
            System.Diagnostics.Debug.WriteLine(FilterEmailUsingKeyword("openshift").Count);
            return this;
        }

        //exp
        public IWebElement Delete => Driver.FindElement(By.CssSelector(@"#\3a 5 > div > div.nH.aqK > div.Cq.aqL > div > div > div:nth-child(2) > div.T-I.J-J5-Ji.nX.T-I-ax7.T-I-Js-Gs.mA.T-I-JW > div"));
        public IList<IWebElement> FilterEmailUsingKeyword(string keyword) => Driver.FindElements(By.TagName("tr")).Where(email => email.Text.Contains(keyword)).ToList();
    }

    public class GoogleLoginElements : LoginElementsV2
    {
        public GoogleLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"identifierId\"]");
            By2 = By.Id("identifierNext");
            By3 = By.CssSelector("input[type='password']");
            By4 = By.Id("passwordNext");
        }
    }
}
