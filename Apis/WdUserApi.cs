using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OElite.Restme.WildDuck.Models;
using OElite.Restme.WildDuck.Models.Users.TransferObjects;

namespace OElite.Restme.WildDuck.Apis
{
    public static class WdUserApi
    {
        private static string ApiPath(string path = null, string prefix = "users")
        {
            return WildDuckApi.ApiPath(path, prefix);
        }


        public static async Task<bool> CreateNewUserAsync(this WildDuckApi api, CreateUserRequest request)
        {
            using var rest = api.Restme();
            var result = await rest.PostAsync<WdBaseResponse>(ApiPath(), request);

            return result?.Success == true;
        }

        public static async Task<bool> DeleteUserAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            var result = await rest.DeleteAsync<WdBaseResponse>(ApiPath(userId));
            return result?.Success == true;
        }

        public static Task<WdBaseEntityCollectionResponse<GetUsersEntityResult>> GetUsers(this WildDuckApi api,
            GetUsersRequest request)
        {
            using var rest = api.Restme();
            return
                rest.PostAsync<WdBaseEntityCollectionResponse<GetUsersEntityResult>>(ApiPath(), request);
        }

        public static async Task<bool> PutUserLogoutAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            var result = await rest.PutAsync<WdBaseResponse>(ApiPath($"{userId}/logout"));
            return result?.Success == true;
        }

        public static void GetUpdates(this WildDuckApi api, string userId)
        {
            throw new NotSupportedException();
        }

        public static async Task<bool> PostUserQuotaAllAsync(this WildDuckApi api)
        {
            using var rest = api.Restme();
            var result = await rest.PostAsync<WdBaseResponse>(ApiPath("quota/reset", null));
            return result?.Success == true;
        }

        public static async Task<bool> PostUserQuotaAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            var result = await rest.PostAsync<WdBaseResponse>(ApiPath($"{userId}/quota/reset"));
            return result?.Success == true;
        }

        public static Task<GetUserEntityResult> GetUserAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<GetUserEntityResult>(ApiPath($"{userId}"));
        }

        public static Task<ResetUserPasswordResult> ResetUserPasswordAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            return rest.PostAsync<ResetUserPasswordResult>(ApiPath($"{userId}/password/reset"));
        }

        public static async Task<string> GetUserIdByUsernameAsync(this WildDuckApi api, string username)
        {
            using var rest = api.Restme();
            var result = await rest.GetAsync<JObject>(ApiPath($"resolve/{username}"));
            return result?.Value<string>("id");
        }

        public static Task<GetUserEntityResult> UpdateUserAsync(this WildDuckApi api, string userId,
            dynamic updatedFields)
        {
            using var rest = api.Restme();
            return rest.PutAsync<GetUserEntityResult>(ApiPath($"{userId}", updatedFields));
        }
    }
}