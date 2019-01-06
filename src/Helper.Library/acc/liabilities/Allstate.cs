using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Allstate : Browser
    {
        public Allstate()
        {
            Settings = new AllstateSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Allstate Login()
        {
            var Elements = new AllstateLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class PaymentCenter : Browser
    {
        public PaymentCenter(Allstate a)
        {
            Driver = a.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("/html/body/my-app/app-myaccount/mya-header/header/nav/div/ul[2]/li[1]/a"), 5).Click();
        }
    }

    public class DocumentCenter : Browser
    {
        public DocumentCenter(Allstate a)
        {
            Driver = a.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("/html/body/my-app/app-myaccount/mya-header/header/nav/div/ul[2]/li[2]/a"), 5).Click();
        }

        public DocumentCenter ViewMostRecentBills()
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"mainContent\"]/div/div/mya-document-center/div/div/div[5]/ul/li/ul/li/div/div[2]/div/mya-document-center-policy-loader[1]/div/div/div/div[2]/div/ul/li[1]/a/span"), 5).Click();
            return this;
        }

        public DocumentCenter ViewAllBills()
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"mainContent\"]/div/div/mya-document-center/div/div/div[5]/ul/li/ul/li/div/div[2]/div/mya-document-center-policy-loader[1]/div/div/div/div[2]/div/ul/li[2]/a/span"), 5).Click();
            return this;
        }

        public DocumentCenter ViewMostRecentPolicyDocuments()
        {
            return this;
        }

        public DocumentCenter ViewAllPolicyDocuments()
        {
            return this;
        }
    }

    public class AllstateLoginElements : LoginElements
    {
        public AllstateLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"mainContent\"]/div/div/app-login/div[2]/div/form/div[2]/div[2]/ul/li[4]/mya-button/button");
        }
    }
}
