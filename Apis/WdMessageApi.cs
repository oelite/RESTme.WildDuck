using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using OElite.Restme.WildDuck.Models;
using OElite.Restme.WildDuck.Models.Mailbox.TransferObjects;
using OElite.Restme.WildDuck.Models.Message;
using OElite.Restme.WildDuck.Models.Message.TransferObjects;
using RabbitMQ.Client;

namespace OElite.Restme.WildDuck.Apis
{
    public static class WdMessageApi
    {
        private static string ApiPath(string userId, string mailboxId, string path = null)
        {
            return WildDuckApi.ApiPath(path, $"users/{userId}/mailboxes/{mailboxId}");
        }

        public static Task<WdBaseResponse> DeleteMessageAsync(this WildDuckApi api, string userId,
            string mailboxId, string messageId)
        {
            using var rest = api.Restme();
            return rest.DeleteAsync<WdBaseResponse>(ApiPath(userId, mailboxId, $"messages/{messageId}"));
        }

        public static async Task<DeleteMessagesResult> DeleteMessagesAsync(this WildDuckApi api, string userId,
            DeleteMessageRequest[] requests)
        {
            var result = new DeleteMessagesResult { Deleted = 0 };
            if (requests?.Length > 0)
            {
                using var rest = api.Restme();
                foreach (var request in requests)
                {
                    var response = await rest.DeleteAsync<WdBaseResponse>(ApiPath(userId, request.MailboxId,
                        $"messages/{request.MessageId}"));
                    if (response?.Success == true)
                    {
                        result.Deleted++;
                    }
                }

                result.Success = result.Deleted == requests.Length;
            }

            return result;
        }

        public static Task<DeleteMessagesResult> DeleteAllMessagesAsync(this WildDuckApi api, string userId,
            string mailboxId)
        {
            using var rest = api.Restme();
            return rest.DeleteAsync<DeleteMessagesResult>(ApiPath(userId, mailboxId, "messages"));
        }

        public static Task<MemoryStream> DownloadAttachmentAsync(this WildDuckApi api, string userId,
            string mailboxId,
            long messageId, string attachmentId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<MemoryStream>(ApiPath(userId, mailboxId,
                $"messages/{messageId}/attachments/{attachmentId}"));
        }

        public static Task<ForwardStoredMessageResult> ForwardStoredMessageAsync(this WildDuckApi api,
            string userId, string mailboxId, long messageId, ForwardStoredMessageRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<ForwardStoredMessageResult>(ApiPath(userId, mailboxId,
                $"messages/{messageId}/forward"), request);
        }

        public static Task<string> GetMessageSourceAsync(this WildDuckApi api, string userId, string mailboxId,
            long messageId)
        {
            using var rest = api.Restme();
            return rest.GetAsync<string>(ApiPath(userId, mailboxId, $"messages/{messageId}/message.eml"));
        }

        public static Task<WdBaseEntityCollectionResponse<WdMessageBaseInfo>> GetMessagesAsync(this WildDuckApi api,
            string userId, string mailboxId, GetMessagesRequest request)
        {
            using var rest = api.Restme();
            var requestObj = new
            {
                unseen = request.Unseen,
                metaData = request.MetaData,
                threadCounters = request.ThreadCounters,
                limit = request.Limit,
                page = request.Page,
                order = request.Order,
                next = request.Next,
                previous = request.Previous
            };
            return rest.GetAsync<WdBaseEntityCollectionResponse<WdMessageBaseInfo>>(
                ApiPath(userId, mailboxId, "messages"), requestObj);
        }

        public static async Task<WdMessageDetail> GetMessageAsync(this WildDuckApi api, string userId, string mailboxId,
            long messageId, bool markAsSeen = false)
        {
            using var rest = api.Restme();
            var result = await rest.GetAsync<GetMessageResult>(
                ApiPath(userId, mailboxId, $"messages/{messageId}"), new
                {
                    markAsSeen = markAsSeen.ToString().ToLower()
                });
            var test = await rest.GetAsync<string>(
                ApiPath(userId, mailboxId, $"messages/{messageId}"), new
                {
                    markAsSeen = markAsSeen.ToString().ToLower()
                });
            if (result?.Success == true)
            {
                return result;
            }

            return null;
        }

        public static Task<WdBaseEntityCollectionResponse<WdMessageBaseInfo>> GetMessagesSearchAsync(
            this WildDuckApi api,
            string userId, GetMessagesSearchRequest request)
        {
            using var rest = api.Restme();
            return rest.GetAsync<WdBaseEntityCollectionResponse<WdMessageBaseInfo>>($"users/{userId}/search",
                request);
        }

        public static Task<SubmitStoredMessageResult> SubmitStoredMessageAsync(this WildDuckApi api,
            string userId, string mailboxId, long messageId, SubmitStoredMessageRequest request)
        {
            using var rest = api.Restme();
            return rest.PostAsync<SubmitStoredMessageResult>(
                ApiPath(userId, mailboxId, $"messages/{messageId}/submit"), request);
        }

        public static Task<UpdateMessageResult> UpdateMessageAsync(this WildDuckApi api, string userId,
            string mailboxId, UpdateMessageRequest request)
        {
            using var rest = api.Restme();
            return rest.PutAsync<UpdateMessageResult>(ApiPath(userId, mailboxId, "messages"), request);
        }

        public static async Task<UploadMessageResponse> UploadMessageAsync(this WildDuckApi api, string userId,
            string mailboxId, UploadMessageRequest request)
        {
            using var rest = api.Restme();
            return await rest.PostAsync<UploadMessageResponse>(ApiPath(userId, mailboxId, "messages"),
                request);
        }
    }
}