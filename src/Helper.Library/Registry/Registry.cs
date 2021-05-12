namespace Helper.Library.Registry
{
    public class FacebookSettings : Settings
    {
        public FacebookSettings()
        {
            Url = "https://fb.com";
            UserId = "userId";
            Password = "pw";
        }
    }

    public class GithubSettings : Settings
    {
        public GithubSettings()
        {
            Url = "https://github.com/login";
            UserId = "userId";
            Password = "pw";
        }
    }

    public class YoutubeSettings : Settings
    {
        public YoutubeSettings()
        {
            Url = "https://accounts.google.com/signin/v2/identifier?passive=true&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Ffeature%3Dshortcut%26app%3Ddesktop%26next%3D%252F%26hl%3Den%26action_handle_signin%3Dtrue&hl=en&uilel=3&service=youtube&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            UserId = "userId";
            Password = "pw";
        }
    }

    public class GmailSettings : Settings
    {
        public GmailSettings()
        {
            Url = "https://gmail.com";
            UserId = "userId";
            Password = "pw";
        }
    }
}
