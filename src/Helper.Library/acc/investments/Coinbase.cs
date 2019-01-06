using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Coinbase : Browser
    {
        public Coinbase()
        {
            Settings = new CoinbaseSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Coinbase Login()
        {
            var Elements = new CoinbaseLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class CoinbaseLoginElements : LoginElements
    {
        public CoinbaseLoginElements()
        {
            By1 = By.XPath("//*[@id=\"email\"]");
            By2 = By.XPath("//*[@id=\"password\"]");
            By3 = By.XPath("//*[@id=\"signin_button\"]");
        }
    }
}
