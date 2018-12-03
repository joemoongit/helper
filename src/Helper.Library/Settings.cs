using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Helper.Library
{
    public class Settings
    {
        public Settings()
        {
            //EnvSettings();
            //LoginSettings();
            //UrlSettings();
        }

        public string UserId
        {
            get => LoginSettings.UserId + "@" + EnvSettings.OrgPrefix + LoginSettings.Org + ".com";
        }

        public IPageSettings EnvSettings
        {
            get
            {
                switch (ConfigurationManager.AppSettings["environment"].ToLower())
                {
                    case "qa":
                        return new QaSettings();
                    case "stg":
                        return new StagingSettings();
                    case "dev":
                        return new DevSettings();
                    case "prod":
                        return new ProdSettings();
                    case "local":
                        return new LocalSettings();
                }
                return null;
            }
        }

        public ILoginSettings LoginSettings
        {
            get => new LoginSettings();
        }

        public IUrlSettings UrlSettings
        {
            get => new UrlSettings();
        }
    }
}
