using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Github : BrowserV2
    {
        public Github()
        {
            Initalize();
            Settings = new GithubSettings();
            NavigateTo(Url);
        }
       
        public Github Login()
        {
            var Elements = new GithubLoginElements(Driver);
            Service.Login(this, Elements);
            return this;
        }
    }

    public class GithubLoginElements : LoginElements
    {
        public GithubLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.Id("login_field");
            By2 = By.Id("password");
            By3 = By.CssSelector("#login > form > div.auth-form-body.mt-3 > input.btn.btn-primary.btn-block");
        }
    }
}
