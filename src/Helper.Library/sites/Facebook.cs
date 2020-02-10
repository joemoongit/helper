using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Helper.Library.Registry;

namespace Helper.Library.Sites
{
    public class Facebook : Browser
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

    public class FacebookAccountSettings : Browser
    {
        public FacebookAccountSettings(Facebook f)
        {
            Driver = f.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath(""), 5);
        }
    }

    public class FacebookHome : Browser
    {
        public FacebookHome(Facebook f)
        {
            Driver = f.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"u_0_c\"]/a"), 5).Click();
        }
    }

    public class FacebookProfilePage : Browser
    {
        public FacebookProfilePage(Facebook f)
        {
            Driver = f.webDriver;
            WebDriver.WaitUntilElementIsVisible(Driver, By.CssSelector("#u_0_a > div:nth-child(1) > div:nth-child(1) > div > a > span > span"), 5).Click();
        }

        public FacebookProfilePage Post(string post)
        {
            WebDriver.WaitUntilElementIsVisible(Driver, By.XPath("//*[@id=\"u_ps_fetchstream_2_3_0\"]"), 5).Click();      //post field
            new Actions(Driver).SendKeys(post).Perform();
            Driver.FindElement(By.XPath("//*[@id=\"u_ps_fetchstream_2_3_3\"]/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/button/span[@class=\"Share\"]")).Click();     //share button
            return this;
        }

        //WIP
        public FacebookProfilePage SavePhotos()
        {
            var Photo = Driver.FindElement(By.CssSelector("#u_ps_fetchstream_2_5_4 > span"));
            Photo.Click();
            var AllPhotos = Driver.FindElements(By.TagName("i"));
            System.Diagnostics.Debug.WriteLine(AllPhotos.Count);
            return this;
        }
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
