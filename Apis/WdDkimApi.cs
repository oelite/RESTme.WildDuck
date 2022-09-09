using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OElite;
using OElite.Restme.WildDuck.Models;
using OElite.Restme.WildDuck.Models.Dkim;
using OElite.Restme.WildDuck.Models.Dkim.TransferObjects;

namespace OElite.Restme.WildDuck.Apis
{
    public static class WdDkimApi
    {
        private static string ApiPath(string path = null, string prefix = "dkim")
        {
            return WildDuckApi.ApiPath(path, prefix);
        }

        public static Task<DkimInfoResult> CreateDkimAsync(this WildDuckApi api, CreateDkimRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<DkimInfoResult>(ApiPath(), request);
        }

        public static Task<WdBaseResponse> DeleteDkimAsync(this WildDuckApi api, string dkimId)
        {
            using var rest = api.Restme();
            return rest.DeleteAsync<WdBaseResponse>(ApiPath(dkimId));
        }

        public static Task<WdBaseEntityCollectionResponse<DkimInfo>> GetDkimsAsync(this WildDuckApi api,
            ListDkimRequest request)
        {
            using var rest = api.Restme();
            return rest.GetAsync<WdBaseEntityCollectionResponse<DkimInfo>>(ApiPath(), request);
        }

        public static Task<DkimInfoResult> GetDkimKeyAsync(this WildDuckApi api, string dkimId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<DkimInfoResult>(ApiPath(dkimId));
        }

        public static async Task<string> GetDkimIdByDomainAsync(this WildDuckApi api, string domain)
        {
            using var rest = api.Restme();
            var result = await rest.GetAsync<JObject>(ApiPath($"resolve/{domain}"));
            return result?.Value<string>("id");
        }
        
    }
}