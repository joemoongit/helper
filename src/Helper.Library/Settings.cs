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
        public IPageSettings EnvSettings;
        public ILoginSettings LoginSettings;
        public IUrlSettings UrlSettings;


        public Settings()
        {
            switch (ConfigurationManager.AppSettings["environment"].ToLower())
            {
                case "qa":
                    this.EnvSettings = new QaSettings();
                    break;
                case "stg":
                    this.EnvSettings = new StagingSettings();
                    break;
                case "dev":
                    this.EnvSettings = new DevSettings();
                    break;
                case "prod":
                    this.EnvSettings = new ProdSettings();
                    break;
                case "local":
                    this.EnvSettings = new LocalSettings();
                    break;
            }
            this.LoginSettings = new LoginSettings();
        }

    }
}
