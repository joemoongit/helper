using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Vanguard : Browser
    {
        public Vanguard()
        {
            Settings = new VanguardSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Vanguard Login()
        {
            var Elements = new VanguardLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class VanguardLoginElements : LoginElements
    {
        public VanguardLoginElements()
        {
            By1 = By.XPath("//*[@id=\"USER\"]");
            By2 = By.XPath("//*[@id=\"PASSWORD\"]");
            By3 = By.XPath("//*[@id=\"login\"]/span");
        }
    }
}
