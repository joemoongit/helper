using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface ISettings
    {
        string Url { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
    }

    public abstract class Settings : ISettings
    {
        private string url;
        private string userId;
        private string password;
         
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
