using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Stackoverflow : Browser
    {
        public Stackoverflow()
        {
            Settings = new StackoverflowSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Stackoverflow Login()
        {
            var Elements = new StackoverflowLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class StackoverflowLoginElements : LoginElements
    {
        public StackoverflowLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"email\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"submit-button\"]");
        }

    }
}
