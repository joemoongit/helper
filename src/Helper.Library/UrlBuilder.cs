using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public class UrlBuilder
    {
        private readonly string Url;

        public UrlBuilder(Settings settings)
        {
            Url = settings.EnvSettings.UrlPrefix + settings.UrlSettings.UrlBody + settings.UrlSettings.UrlSuffix;
        }

        public string ReturnUrl()
        {
            return Url;
        }
    }
}
