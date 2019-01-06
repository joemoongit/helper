using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface ISettingsV2
    {
        string Url { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
    }

    //template
    public abstract class SettingsV2 : ISettingsV2
    {
        private string url = "url";
        private string userId = "defaultUserId";
        private string password = "defaultPassword";

        public string Url
        {
            get => url;
            set => url = value;
        }

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
    }
}
