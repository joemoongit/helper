using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Youtube : BrowserV3
    {
        public Youtube()
        {
            Driver = WebDriver.Driver();
            Settings = new YoutubeSettings();
            NavigateTo(Url);
        }
        
        public Youtube Login()
        {
            var Elements = new GoogleLoginElements(Driver);
            Service.LoginGoogle(this, Elements);
            return this;
        }
    }   
}
