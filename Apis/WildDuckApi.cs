using OElite;

namespace OElite.Restme.WildDuck.Apis
{
    public class WildDuckApi
    {
        private string ApiKey { get; set; }
        private string ApiEndpoint { get; set; }

        private WildDuckApi(string apiEndpoint, string apiKey)
        {
            ApiKey = apiKey;
            ApiEndpoint = apiEndpoint;
        }

        public static WildDuckApi Instance(string apiEndpoint, string apiKey)
        {
            return new WildDuckApi(apiEndpoint, apiKey);
        }

        public Rest Restme()
        {
            if (ApiKey.IsNotNullOrEmpty() && ApiEndpoint.IsNotNullOrEmpty())
            {
                var restClient = new Rest(ApiEndpoint);
                restClient.AddHeader("X-Access-Token", ApiKey);
                return restClient;
            }

            throw new OEliteSecurityException("Invalid Api endpoint or Api Key");
        }

        public static string ApiPath(string path, string prefix = null)
        {
            path = path?.Trim(new char[] {'/'});
            prefix = prefix?.Trim(new char[] {'/'});
            return $"{prefix}{(path.IsNotNullOrEmpty() ? "/" + path : path)}";
        }
    }
}