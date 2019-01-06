using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Tmobile : Browser
    {
        public Tmobile()
        {
            Settings = new TmobileSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Tmobile Login()
        {
            var Elements = new TmobileLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class TmobileLoginElements : LoginElements
    {
        public TmobileLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"username\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"loginSpa\"]/div/div[2]/div/div/div/section/div[1]/form/div[4]/div[1]/div/input");
        }
    }
}
