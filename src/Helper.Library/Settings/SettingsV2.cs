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
        public string Url
        {
            get => "Url";
            set => Url = value;
        }

        public string UserId
        {
            get => "UserId";
            set => UserId = value;
        }

        public string Password
        {
            get => "Password";
            set => Password = value;
        }
    }
}
