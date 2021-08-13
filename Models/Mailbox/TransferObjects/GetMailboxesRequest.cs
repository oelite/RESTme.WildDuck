using System.Collections.Generic;

namespace RESTme.WildDuck.Models.Mailbox.TransferObjects
{
    public class GetMailboxesRequest
    {
        public string UserId { get; set; }
        public bool SpecialUse { get; set; }
    }

    public class GetMailboxesResponse : WdBaseResponse
    {
        public List<WdMailboxInfo> Results { get; set; }
    }
}