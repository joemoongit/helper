using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Helper.Library.Sites
{
    public class Pcc : BrowserV2
    {
        public Pcc()
        {
            Initalize();
            Settings = new PccSettings();
            NavigateTo(Url);
        }

        public Pcc Login()
        {
            var Elements = new PccLoginElements();
            Service.Login(this, Elements);
            return this;
        }
    }

    public class AddClasses : Pcc
    {
        public AddClasses()
        {

        }
    }

    public class ScheduleOfClasses : Pcc
    {
        public ScheduleOfClasses()
        {

        }
    }

    public class Transcript : Pcc
    {
        public Transcript()
        {

        }
    }

    public class PccLoginElements : LoginElements
    {
        public PccLoginElements()
        {
            By1 = By.XPath("");
            By2 = By.XPath("");
            By3 = By.XPath("");
        }
    }
}
