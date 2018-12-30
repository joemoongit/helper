using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



namespace Helper.Library.Sites
{
    public class Facebook : BrowserV2
    {
        public Facebook()
        {
            Initalize();
            Settings = new FacebookSettings();
            NavigateTo(Url);
        }

        public Facebook Login()
        {
            var Elements = new FacebookLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class FacebookAccountSettings : BrowserV2
    {
        public FacebookAccountSettings(Facebook f)
        {
            Driver = f.webDriver();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath(""), 5);
        }
    }

    public class FacebookHome : BrowserV2
    {
        public FacebookHome(Facebook f)
        {
            Driver = f.webDriver();
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"u_0_c\"]/a"), 5).Click();
        }
    }

    public class FacebookPost : BrowserV2                       //direct post method will call it like human would
    {
        public FacebookPost(string post)
        {
            Driver.FindElement(By.XPath("//*[@id=\"u_0_a\"]/div[1]/div[1]/div/a/span/span")).Click();       //profile page button
            Driver.FindElement(By.XPath("//*[@id=\"js_tl\"]/div/div/div[2]/div/div/div/div")).Click();      //post field
            Driver.FindElement(By.XPath("//*[@id=\"js_tl\"]/div/div/div[2]/div/div/div/div")).SendKeys(post);       //post field
            Driver.FindElement(By.XPath("//*[@id=\"js_t0\"]/div[2]/div[3]/div[2]/div/div/button")).Click();     //share button
        }
    }

    public class FacebookProfilePage : BrowserV2
    {
        public FacebookProfilePage(Facebook f)
        {
            Driver = f.webDriver();
            WebDriver.WaitUntilElementIsVisible(Driver, By.CssSelector("#u_0_a > div:nth-child(1) > div:nth-child(1) > div > a > span > span"), 5).Click();

        }

        public FacebookProfilePage Post(string post)
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"u_ps_fetchstream_2_3_0\"]"), 5).Click();      //post field

            new Actions(Driver).SendKeys(post).Perform();

            Driver.FindElement(By.XPath("//*[@id=\"u_ps_fetchstream_2_3_3\"]/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/button/span[@class=\"Share\"]")).Click();     //share button
            //Driver.FindElement(By.TagName("button")).Click();
            return this;
        }

        public FacebookProfilePage SavePhotos()
        {
            Photo.Click();
            System.Diagnostics.Debug.WriteLine(AllPhotos.Count);
            return this;
        }
        public IWebElement Photo => Driver.FindElement(By.CssSelector("#u_ps_fetchstream_2_5_4 > span"));
        public IList<IWebElement> AllPhotos => Driver.FindElements(By.TagName("i"));
    }

    public class FacebookCreate : BrowserV2
    {

    }

    public class FacebookLoginElements : LoginElements
    {
        public FacebookLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.Id("email");
            By2 = By.Id("pass");
            By3 = By.Id("loginbutton");
        }
    }
}
