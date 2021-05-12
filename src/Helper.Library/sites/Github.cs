using OpenQA.Selenium;
using Helper.Library.Registry;

namespace Helper.Library.Sites
{
    public class Github : Browser
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
            By3 = By.XPath("//*[@id=\"login\"]/div[4]/form/div/input[12]");
        }
    }
}
