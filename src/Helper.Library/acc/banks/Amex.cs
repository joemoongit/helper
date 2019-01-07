using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Amex : Browser
    {
        public Amex()
        {
            Settings = new AmexSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Amex Login()
        {
            var Elements = new AmexLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class AmexExpFeatures : Browser
    {
        public AmexExpFeatures(Amex a)
        {
            Driver = a.webDriver;
            var StatementAndActivityDropdown = Driver.FindElement(By.CssSelector("#root > div:nth-child(1) > div > div:nth-child(2) > div > div > div.body > div:nth-child(2) > div > div > header > div > div > div > div > div > div > div.hidden-sm-down > div > div.col-xs-10.pad-0-lr > div > ul > li:nth-child(2) > a"));
            var BillingStatementAndDocumentsButton = Driver.FindElement(By.XPath("//*[@id=\"s_LinkBilling\"]"));
            StatementAndActivityDropdown.Click();
            BillingStatementAndDocumentsButton.Click();
        }

        public AmexExpFeatures PullStatements()
        {
            var BillingStatements = Driver.FindElements(By.TagName("a"));
            System.Diagnostics.Debug.WriteLine(BillingStatements.Count);
            return this;
        }
    }

    public class AmexLoginElements : LoginElements
    {
        public AmexLoginElements()
        {
            By1 = By.XPath("//*[@id=\"login-user\"]");
            By2 = By.XPath("//*[@id=\"login-password\"]");
            By3 = By.XPath("//*[@id=\"login-submit\"]");
        }
    }
}
