using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Packtpub : BrowserV2
    {
        public Packtpub()
        {
            Initalize();
            Settings = new PacktpubSettings();
            NavigateTo(Url);
        }
        
        public Packtpub Login()
        {
            var Elements = new PacktpubLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class PacktpubLoginElements : LoginElements
    {
        public PacktpubLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.Id("edit-name");
            By2 = By.Id("edit-pass");
            By3 = By.Id("edit-post-form");
        }
    }
}
