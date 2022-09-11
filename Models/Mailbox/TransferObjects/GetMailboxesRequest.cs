using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Mailbox.TransferObjects
{
    public class GetMailboxesRequest
    {
        public bool? SpecialUse { get; set; }
        public bool? ShowHidden { get; set; }
        public bool? Counters { get; set; }
        public bool? Sizes { get; set; }
    }

    public class GetMailboxesResponse : WdBaseResponse
    {
        public List<WdMailboxInfo> Results { get; set; }
    }
}