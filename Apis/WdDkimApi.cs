using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Core;
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
            var queryBuilder = new UriQueryBuilder();
            if (request?.Query?.IsNotNullOrEmpty() == true)
                queryBuilder.Add("query", request.Query);
            if (request?.Next > 0)
                queryBuilder.Add("next", request.Next.ToString());
            if (request?.Limit > 0)
                queryBuilder.Add("limit", request.Limit.ToString());
            if (request?.Previous > 0)
                queryBuilder.Add("previous", request.Previous.ToString());
            if (request?.Page > 0)
                queryBuilder.Add("page", request.Page.ToString());
            var url = $"{ApiPath()}{queryBuilder}";
            return rest.GetAsync<WdBaseEntityCollectionResponse<DkimInfo>>(url);
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