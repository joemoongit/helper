using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library.Sites
{
    public class Webull : Browser
    {
        public Webull()
        {
            Settings = new WebullSettings();
            Initalize();
            NavigateTo(Url);
        }
    }
}
