using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Helper.Library.Domain;

namespace Helper.Library
{
    public class PostJsonToServer : Browser
    {
        protected N1Child1 cpage;

        public PostJsonToServer(LoginPage loginPage)
        {
            cpage = new N1Child1(loginPage);
        }

        private readonly static string JsonPost =
            @"{
                'Key1': 'Value1',
                'Key2': 'Value2',
                'Key3': 'Value3',
                'Key4': 'Value4',
                'Key5': 'Value5',
                'Key6': 'Value6',
                'Key7': 'Value7'
            }";

        private static bool IsNumeric(string someString)
        {
            return double.TryParse(someString, out double n);
        }

        public async Task HttpClient(string url, string NewLeadJsonPost)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    url,
                    new StringContent(NewLeadJsonPost, Encoding.UTF8, "application/json"));
            }
        }

        public async Task<PostJsonToServer> PostToCampaign2<T>(T campaignNumberOrName)
        {
            string url;
            if (IsNumeric(campaignNumberOrName.ToString()))
            {
                url = Settings.EnvSettings.UrlPrefix + ".insellerate.com/api/integration/CampaignPost/1001/" + campaignNumberOrName;
            }
            else
            {
                //url = cpage.ReturnUrlUsingEndpointName(campaignNumberOrName.ToString());
                url = "";
            }

            string Post;

            Post = "{'root':{'row':[" + JsonPost + "]}}";
            await HttpClient(url, Post);
            return this;
        }

        public async Task<PostJsonToServer> PostToCampaign<T, U>(T campaignNumberOrName, U quantityOfNewLeadsToPost)
        {
            string url;
            if (IsNumeric(campaignNumberOrName.ToString()))
            {
                url = Settings.EnvSettings.UrlPrefix + ".insellerate.com/api/integration/CampaignPost/1001/" + campaignNumberOrName;
            }
            else
            {
                //url = cpage.ReturnUrlUsingEndpointName(campaignNumberOrName.ToString());
                url = "";
            }

            string Post;
            string JsonPosts = "";

            if (Int32.Parse(quantityOfNewLeadsToPost.ToString()) > 0)
            {
                for (var i = 0; i < Int32.Parse(quantityOfNewLeadsToPost.ToString()); i++)
                {
                    if (i == 0)
                    {
                        JsonPosts += JsonPost;
                    }
                    else
                    {
                        JsonPosts += "," + JsonPost;
                    }
                }
                Post = "{'root':{'row':[" + JsonPosts + "]}}";
            }
            else
            {
                Post = "{'root':{'row':[" + JsonPost + "]}}";
            }

            await HttpClient(url, Post);
            return this;
        }
    }
}
