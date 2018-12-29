using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface ISettings
    {
        string Url { get; }
        string UserId { get; }
        string Password { get; }
    }

    //template
    public abstract class Settings : ISettings
    {
        public string Url => "Url";
        public string UserId => "UserId";
        public string Password => "Password";
    }
}