using System.Dynamic;
using System.Threading.Tasks;
using OElite;
using OElite.Restme.WildDuck.Models;
using OElite.Restme.WildDuck.Models.Mailbox;
using OElite.Restme.WildDuck.Models.Mailbox.TransferObjects;

namespace OElite.Restme.WildDuck.Apis
{
    public static class WdMailboxApi
    {
        private static string ApiPath(string path = null, string prefix = "users")
        {
            return WildDuckApi.ApiPath(path, prefix);
        }

        public static Task<CreateMailboxResult> CreateNewMailboxAsync(this WildDuckApi api, string userId,
            CreateMailboxRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<CreateMailboxResult>(ApiPath($"{userId}/mailboxes"), request);
        }

        public static Task<WdBaseResponse> DeleteMailboxAsync(this WildDuckApi api, string userId, string mailbox)
        {
            using var rest = api.Restme();
            return rest.DeleteAsync<WdBaseResponse>(ApiPath($"{userId}/mailboxes/{mailbox}"));
        }

        public static Task<GetMailboxesResponse> GetMailboxesAsync(this WildDuckApi api, string userId,
            GetMailboxesRequest request)
        {
            using var rest = api.Restme();
            var requestObj = new
            {
                specialUse = request.SpecialUse,
                showHidden = request.ShowHidden,
                counters = request.Counters,
                sizes = request.Sizes
            };


            return rest.GetAsync<GetMailboxesResponse>(ApiPath($"{userId}/mailboxes"),
                requestObj);
        }

        public static Task<GetMailboxResponse> GetMailboxAsync(this WildDuckApi api, string userId,
            string mailboxId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<GetMailboxResponse>(ApiPath($"{userId}/mailboxes/{mailboxId}"));
        }

        public static Task<WdBaseResponse> UpdateMailboxAsync(this WildDuckApi api, string userId,
            UpdateMailboxRequest request)
        {
            using var rest = api.Restme();
            return rest.PutAsync<WdBaseResponse>(ApiPath($"{userId}/mailboxes/{request?.Mailbox}"), request);
        }
    }
}