using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface ILoginSettings
    {
        string UserId { get; set; }
        string Password { get; set; }
        string Org { get; set; }
    }

    public class LoginSettings : ILoginSettings
    {
        private string userId = "admin1";
        private string password = "sweet4$";
        private string org = "test";

        public string UserId
        {
            get => userId;
            set => userId = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
        public string Org
        {
            get => org;
            set => org = value;
        }
    }

    public class MyLoginSettings : LoginSettings
    {
        public MyLoginSettings()
        {
            UserId = "joseph";
        }
    }

    public class FacebookLoginSettings : LoginSettings
    {
        public FacebookLoginSettings()
        {
            UserId = "FB user id";
            Password = "FB pw";
        }
    }
}

//public class AdminSettings : LoginSettings
//{
//    public AdminSettings()
//    {
//        UserId = "admin1";
//    }
//}

//public class SuperAdminLoginSettings : LoginSettings
//{
//    public SuperAdminSettings()
//    {
//        UserId = "superadmin";
//    }
//}