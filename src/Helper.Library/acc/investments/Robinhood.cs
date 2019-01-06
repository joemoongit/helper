using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Robinhood : Browser
    {
        public Robinhood()
        {
            Settings = new RobinhoodSettings();
            Initalize();
            NavigateTo(Url);
        }

        public Robinhood Login()
        {
            var Elements = new RobinhoodLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class RobinhoodLoginElements : LoginElements
    {
        public RobinhoodLoginElements()
        {
            By1 = By.XPath("//*[@id=\"react_root\"]/div/div/div/div[2]/div/div/form/div/div/div[1]/label/div[2]/input");
            By2 = By.XPath("//*[@id=\"react_root\"]/div/div/div/div[2]/div/div/form/div/div/div[2]/label/div[2]/input");
            By3 = By.XPath("//*[@id=\"react_root\"]/div/div/div/div[2]/div/div/form/footer/div/button");
        }
    }
}
