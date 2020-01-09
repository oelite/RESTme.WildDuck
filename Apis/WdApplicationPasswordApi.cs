using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RESTme.WildDuck.Models;
using RESTme.WildDuck.Models.ApplicationPasswords.TransferObjects;

namespace RESTme.WildDuck.Apis
{
    public static class WdApplicationPasswordApi
    {
        private static string ApiPath(string userId, string path = null, string prefix = "asps")
        {
            return WildDuckApi.ApiPath(path, $"users/{userId}/{prefix}");
        }

        public static Task<NewApplicationPasswordResult> GenerateNewApplicationPasswordAsync(this WildDuckApi api,
            string userId,
            NewApplicationPasswordRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<NewApplicationPasswordResult>(ApiPath(userId), request);
        }

        public static async Task<bool> DeleteApplicationPasswordAsync(this WildDuckApi api, string userId,
            string passwordId)
        {
            using var rest = api.Restme();
            var result = await rest.DeleteAsync<WdBaseResponse>(ApiPath(userId, $"asps/{passwordId}"));
            return result?.Success == true;
        }

        public static Task<ListApplicationResult> ListApplicationPasswordsAsync(this WildDuckApi api, string userId,
            bool showAll = false)
        {
            using var rest = api.Restme();
            return rest.GetAsync<ListApplicationResult>(ApiPath(userId, $"asps?showAll={showAll}"));
        }
    }
}