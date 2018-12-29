using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Gmail : BrowserV3
    {
        public Gmail(string userId = null, string password = null)
        {
            Initalize();
            Settings = new GmailSettingsV2();
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
            SelectAllEmails.Click();
            MarkAsRead.Click();
            return this;
        }

        public Gmail LocateAllEmails()
        {
            System.Diagnostics.Debug.WriteLine(AllEmails.Count);

            foreach(var email in AllEmails)
            {
                System.Diagnostics.Debug.WriteLine(email.Text);
            }

            System.Diagnostics.Debug.WriteLine(AllPytorchEmails.Count);
            System.Diagnostics.Debug.WriteLine(AllOpenshiftEmails.Count);
            return this;
        }

        //exp
        public IWebElement SelectAllEmails => WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@role=\"button\"]/div[1]/span"), 10);

        public IWebElement Delete => Driver.FindElement(By.CssSelector(@"#\3a 5 > div > div.nH.aqK > div.Cq.aqL > div > div > div:nth-child(2) > div.T-I.J-J5-Ji.nX.T-I-ax7.T-I-Js-Gs.mA.T-I-JW > div"));       //use xpath
        public IWebElement MarkAsRead => Driver.FindElement(By.CssSelector(@"#\3a 5 > div > div.nH.aqK > div.Cq.aqL > div > div > div:nth-child(3) > div.T-I.J-J5-Ji.m9.T-I-ax7.L3 > div"));        //use xpath

        public IList<IWebElement> AllEmails => Driver.FindElements(By.TagName("tr")).Where(email => !string.IsNullOrEmpty(email.Text)).ToList();


        public IList<IWebElement> AllPytorchEmails => Driver.FindElements(By.TagName("tr")).Where(email => email.Text.Contains("pytorch")).ToList();

        public IList<IWebElement> AllOpenshiftEmails => Driver.FindElements(By.TagName("tr")).Where(email => email.Text.Contains("openshift")).ToList();
    }

    public class GmailAccountSettings : BrowserV2
    {
        public GmailAccountSettings(Gmail g)
        {
            Driver = g.webDriver();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"gbwa\"]/div"), 5).Click();
            Driver.FindElement(By.XPath("//*[@id=\"gb192\"]"));
        }
    }

    public class GoogleDrive : BrowserV2
    {
        public GoogleDrive(Gmail g)
        {
            Driver = g.webDriver();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"gbwa\"]/div/a/svg"), 5).Click();
            Driver.FindElement(By.XPath("//*[@id=\"gb49\"]/span[1]"));
        }
    }

    public class GooglePhotos : Gmail
    {
        public GooglePhotos()
        {

        }
    }

    public class GoogleLoginElements : LoginElements
    {
        public GoogleLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"identifierId\"]");
            By2 = By.CssSelector("input[type='password']");
            By3 = By.Id("identifierNext");
        }
        public IWebElement PasswordNextButton => Driver.FindElement(By.Id("passwordNext"));
    }

    public class GmailSettingsV2 : ISettingsV2
    {
        public string Url
        {
            get => "https://gmail.com";
            set => Url = value;
        }

        public string UserId
        {
            get => "thisisforadss";
            set => UserId = value;
        }

        public string Password
        {
            get => "Sprite1234";
            set => Password = value;
        }
    }
}
