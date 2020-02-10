using Helper.Library.Registry;

namespace Helper.Library.Sites
{
    public class Youtube : Browser
    {
        public Youtube()
        {
            Driver = WebDriver.Driver();
            Settings = new YoutubeSettings();
            NavigateTo(Url);
        }
        
        public Youtube Login()
        {
            var Elements = new GoogleLoginElements(Driver);
            Service.LoginGoogle(this, Elements);
            return this;
        }
    }   
}
