using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Directvnow : Browser
    {
        public Directvnow()
        {
            Settings = new DirectvnowSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Directvnow Login()
        {
            var Elements = new DirectvnowLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class DirectvnowLoginElements : LoginElements
    {
        public DirectvnowLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"userName\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"loginButton-lgwgLoginButton\"]/span");
        }
    }
}
