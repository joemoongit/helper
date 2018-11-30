using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public interface IPageSettings
    {
        string UrlPrefix { get; }
        string PasswordSuffix { get; }
        string OrgPrefix { get; }
    }

    //public class PageSettings : IPageSettings { }
    //public class QaSettings : PageSettings { }

    public class QaSettings : IPageSettings
    {
        public string UrlPrefix => "https://joe-qa";
        public string PasswordSuffix => "Q";
        public string OrgPrefix => "qa1-";
    }

    public class LocalSettings : IPageSettings
    {
        public string UrlPrefix => "https://localhost:1234";
        public string PasswordSuffix => "";
        public string OrgPrefix => "";
    }

    public class StagingSettings : IPageSettings
    {
        public string UrlPrefix => "https://joe-stg";
        public string PasswordSuffix => "S";
        public string OrgPrefix => "staging1-";
    }

    public class DevSettings : IPageSettings
    {
        public string UrlPrefix => "https://joe-dev";
        public string PasswordSuffix => "D";
        public string OrgPrefix => "dev1-";
    }

    public class ProdSettings : IPageSettings
    {
        public string UrlPrefix => "https://app";
        public string PasswordSuffix => "P";
        public string OrgPrefix => "prod1-";
    }
}
