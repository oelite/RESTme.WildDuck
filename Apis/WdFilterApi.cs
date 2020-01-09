using System.Threading.Tasks;
using RESTme.WildDuck.Models;
using RESTme.WildDuck.Models.Filters;
using RESTme.WildDuck.Models.Filters.TransferObjects;

namespace RESTme.WildDuck.Apis
{
    public static class WdFilterApi
    {
        private static string ApiPath(string userId, string path = null, string prefix = "users")
        {
            return WildDuckApi.ApiPath(path, $"users/{userId}");
        }

        public static Task<CreateFilterResult> CreateNewFilterAsync(this WildDuckApi api, string userId,
            CreateFilterRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<CreateFilterResult>(ApiPath(userId, "filters"), request);
        }

        public static async Task<bool> DeleteFilterAsync(this WildDuckApi api, string userId, string filterId)
        {
            using var rest = api.Restme();
            var result = await rest.DeleteAsync<WdBaseResponse>(ApiPath(userId, $"filters/{filterId}"));
            return result?.Success == true;
        }

        public static Task<ListFilterResult> GetFiltersAsync(this WildDuckApi api, string userId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<ListFilterResult>(ApiPath(userId));
        }

        public static Task<GetFilterResult> GetFilterAsync(this WildDuckApi api, string userId, string filterId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<GetFilterResult>(ApiPath(userId, $"filters/{filterId}"));
        }

        public static Task<WdBaseResponse> UpdateFilterAsync(this WildDuckApi api, string userId, string filterId,
            WdFilterInfo request)
        {
            using var rest = api.Restme();
            return rest.PutAsync<WdBaseResponse>(ApiPath(userId, $"filters/{filterId}"), request);
        }
    }
}