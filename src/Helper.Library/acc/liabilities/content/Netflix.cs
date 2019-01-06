using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Netflix : Browser
    {
		public Netflix()
        {
            Settings = new NetflixSettings();
            Initalize();
            NavigateTo(Url);
        }
    }

	public class NetflixLoginElements : LoginElements
    {
		public NetflixLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"id_userLoginId\"]");
            By2 = By.XPath("//*[@id=\"id_password\"]");
            By3 = By.XPath("//*[@id=\"appMountPoint\"]/div/div[3]/div/div/div[1]/form/button");
        }
    }
}
