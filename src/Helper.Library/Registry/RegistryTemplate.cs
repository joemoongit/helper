using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library.Registry
{
    public class FacebookSettings : ISettings
    {
        public string Url => "https://fb.com";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class GithubSettings : ISettings
    {
        public string Url => "https://github.com/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class GmailSettings : ISettings
    {
        public string Url => "https://gmail.com";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class PacktpubSettings : ISettings
    {
        public string Url => "https://www.packtpub.com/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class PccSettings : ISettings
    {
        public string Url => "http://lancerpoint.pasadena.edu/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    //banks
    public class AmexSettings : ISettings
    {
        public string Url => "https://www.americanexpress.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class BoaSettings : ISettings
    {
        public string Url => "https://www.bankofamerica.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class CitiSettings : ISettings
    {
        public string Url => "https://online.citi.com/US/login.do";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class WellsFargoSettings : ISettings
    {
        public string Url => "https://www.wellsfargo.com";
        public string UserId => "userId";
        public string Password => "pw";
    }

    //investments
    public class CoinbaseSettings : ISettings
    {
        public string Url => "https://www.coinbase.com/signin";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class RobinhoodSettings : ISettings
    {
        public string Url => "https://robinhood.com/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class VanguardSettings : ISettings
    {
        public string Url => "https://investor.vanguard.com/my-account/log-on";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class Iowa529Settings : ISettings
    {
        public string Url => "https://www.collegesavingsiowa.com/iatpl/auth/ll.cs";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class WebullSettings : ISettings
    {
        public string Url => "https://www.webull.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    //liabilities
    public class AllstateSettings : ISettings
    {
        public string Url => "https://myaccountrwd.allstate.com/anon/account/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class FedloanSettings : ISettings
    {
        public string Url => "https://myfedloan.org/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class NissanSettings : ISettings
    {
        public string Url => "https://accounts.nissanusa.com/aas15/pages/login.jsf";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class ToyotaSettings : ISettings
    {
        public string Url => "https://www.toyotafinancial.com/us/en/external_login.html";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class AttSettings : ISettings
    {
        public string Url => "https://www.att.com/my/#/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class TmobileSettings : ISettings
    {
        public string Url => "https://my.t-mobile.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class TmobileSettings2 : ISettings
    {
        public string Url => "https://my.t-mobile.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class DirectvnowSettings : ISettings
    {
        public string Url => "https://www.directvnow.com/accounts/sign-in";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class NetflixSettings : ISettings
    {
        public string Url => "https://www.netflix.com/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class HuluSettings : ISettings
    {
        public string Url => "https://www.hulu.com/welcome";
        public string UserId => "";
        public string Password => "";
    }

    public class PaychexSettings : ISettings
    {
        public string Url => "https://myapps.paychex.com/landing_remote/login.do?TYPE=33554433&REALMOID=06-fd3ba6b8-7a2f-1013-ba03-83af2ce30cb3&GUID=&SMAUTHREASON=0&METHOD=GET&SMAGENTNAME=-SM-DcRXd3RBkM%2bIAuUkJhio4qMQPGHXSlwC5NHvGd60RCkP6guTqWS4qLnJtYdJd9Ge&TARGET=-SM-https%3a%2f%2fmyapps%2epaychex%2ecom%2f";
        public string UserId => "userId";
        public string Password => "pw";
    }

    //retail
    public class AmazonSettings : ISettings
    {
        public string Url => "https://www.amazon.com/ap/signin?_encoding=UTF8&ignoreAuthState=1&openid.assoc_handle=usflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2Fb%3Fie%3DUTF8%26node%3D14730500011%26ref_%3Dnav_custrec_signin&switch_account=";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class EbaySettings : ISettings
    {
        public string Url => "https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&regUrl=https%3A%2F%2Freg.ebay.com%2Freg%2FPartialReg";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class WalmartSettings : ISettings
    {
        public string Url => "https://www.walmart.com/account/login";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class SamsungSettings : ISettings
    {
        public string Url => "https://www.samsung.com/us/support/account/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class WalgreensSettings : ISettings
    {
        public string Url => "https://www.walgreens.com/login.jsp?clearIntent=true";
        public string UserId => "userId";
        public string Password => "pw";
    }

    //mobile apps
    public class TwitterSettings : ISettings
    {
        public string Url => "https://twitter.com/login?lang=en";
        public string UserId => "";
        public string Password => "";
    }

    public class SnapchatSettings : ISettings
    {
        public string Url => "";
        public string UserId => "";
        public string Password => "";
    }
    public class GasbuddySettings : ISettings
    {
        public string Url => "https://iam.gasbuddy.com/login?return_url=https://www.google.com/";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class StarbucksSettings : ISettings
    {
        public string Url => "https://www.starbucks.com/account/signin";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class McdonaldsSettings : ISettings
    {
        public string Url => "https://www.mcdonalds.com/us/en-us/subscription.html";
        public string UserId => "userId";
        public string Password => "pw";
    }

    public class YoutubeSettings : ISettingsV2
    {
        private string url = "https://accounts.google.com/signin/v2/identifier?passive=true&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Ffeature%3Dshortcut%26app%3Ddesktop%26next%3D%252F%26hl%3Den%26action_handle_signin%3Dtrue&hl=en&uilel=3&service=youtube&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        private string userId = "userId";
        private string password = "pw";

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

    public class GmailSettingsV2 : ISettingsV2
    {
        private string url = "https://gmail.com";
        private string userId = "userId";
        private string password = "pw";

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

    public class StackoverflowSettings : ISettings
    {
        public string Url => "https://stackoverflow.com/users/login";
        public string UserId => "userId";
        public string Password => "pw";
    }
}
