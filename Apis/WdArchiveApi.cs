using System.Threading.Tasks;
using RESTme.WildDuck.Models;
using RESTme.WildDuck.Models.Message;
using RESTme.WildDuck.Models.Message.TransferObjects;

namespace RESTme.WildDuck.Apis
{
    public static class WdArchiveApi
    {
        private static string ApiPath(string userId, string path = null, string prefix = "archived")
        {
            return WildDuckApi.ApiPath(path, $"users/{userId}/{prefix}");
        }

        public static Task<WdBaseEntityCollectionResponse<WdMessageBaseInfo>> ListDeletedMessages(this WildDuckApi api,
            string userId, ListDeletedMessageRequest request)
        {
            using var rest = api.Restme();
            return rest.GetAsync<WdBaseEntityCollectionResponse<WdMessageBaseInfo>>(
                ApiPath(userId, "archived/messages"),
                request);
        }

        public static Task<RestoreMessageResult> RestoreDeletedMessageAsync(this WildDuckApi api, string userId,
            long messageId, RestoreMessageRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<RestoreMessageResult>(ApiPath(userId, $"archived/messages/{messageId}/restore"),
                request);
        }

        public static async Task<bool> RestoreDeletedMessagesAsync(this WildDuckApi api, string userId,
            RestoreMessagesRequest request)
        {
            using var rest = api.Restme();
            var result = await rest.PostAsync<WdBaseResponse>(ApiPath(userId, "archived/restore"), request);
            return result?.Success == true;
        }
    }
}