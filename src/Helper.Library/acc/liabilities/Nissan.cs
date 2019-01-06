using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Nissan : Browser
    {
        public Nissan(Browser browser = null)
        {
            Settings = new NissanSettings();
            Initalize();            
            NavigateTo(Url);
        }

        public Nissan Login()
        {
            var Elements = new NissanLoginElements(Driver);
            Service.Login(this, Elements);
            Driver.FindElement(By.XPath("//*[@id=\"sessionform\"]/div/div[2]/div/a")).Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60:pinid\"]")));
            Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60:pinid\"]")).SendKeys("120717");
            Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60\"]/div[1]/table/tbody/tr[4]/td[2]/input")).Click();
            //Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60:pinid\"]")).Click();
            //Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60:pinid\"]")).SendKeys("120717");
            //Driver.FindElement(By.XPath("//*[@id=\"j_id0: j_id60\"]/div[1]/table/tbody/tr[4]/td[2]/input")).Click();
            return this;
        }
    }
    
    public class NissanLoginElements : LoginElements
    {
        public NissanLoginElements(IWebDriver driver)
        {
            Driver = driver;
            By1 = By.XPath("//*[@id=\"loginform:UserName\"]");
            By2 = By.XPath("//*[@id=\"loginform:Password\"]");
            By3 = By.XPath("//*[@id=\"loginform:login\"]");
        }
    }

}
