using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Iowa529 : Browser
    {
        public Iowa529()
        {
            Settings = new Iowa529Settings();
            Initalize();
            NavigateTo(Url);
        }

        public Iowa529 Login()
        {
            var Elements = new Iowa529LoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class Iowa529LoginElements : LoginElements
    {
        public Iowa529LoginElements()
        {
            By1 = By.XPath("");
            By2 = By.XPath("");
            By3 = By.XPath("");
        }
    }
}
