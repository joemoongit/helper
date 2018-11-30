using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface IUrlSettings
    {
        string FullUrl { get; set; }
        string UrlBody { get; }
        string UrlSuffix { get; set; }
    }

    public class UrlSettings : IUrlSettings
    {
        public string UrlBody => ".josephmoon.com/";

        private string urlSuffix = "/Login";

        public string UrlSuffix
        {
            get => urlSuffix;
            set => urlSuffix = value;
        }

        public string FullUrl
        {
            get => FullUrl;
            set => FullUrl = value;
        }
    }
}
