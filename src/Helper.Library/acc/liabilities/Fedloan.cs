using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Fedloan : Browser
    {
        public Fedloan()
        {
            Settings = new FedloanSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Fedloan Login()
        {
            var Elements = new FedloanLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class FedloanLoginElements : LoginElements
    {
        public FedloanLoginElements()
        {
            By1 = By.XPath("");
            By2 = By.XPath("");
            By3 = By.XPath("");
        }
    }

}
