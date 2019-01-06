using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Verizon : Browser
    {
        public Verizon()
        {
            Settings = new VerizonSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Verizon Login()
        {
            var Elements = new VerizonLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class VerizonSettings : ISettings
    {
        public string Url => "https://www.verizonwireless.com/my-verizon/";
        public string UserId => "";
        public string Password => "";
    }

    public class VerizonLoginElements : LoginElements
    {
        public VerizonLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"IDToken1\"]");
            By2 = By.XPath("//*[@id=\"IDToken2\"]");
            By3 = By.XPath("//*[@id=\"login-submit\"]");
        }
    }
}
