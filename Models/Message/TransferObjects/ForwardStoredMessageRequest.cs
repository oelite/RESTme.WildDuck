using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class ForwardStoredMessageRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public string Message { get; set; }
        public string Target { get; set; }
        public string[] Addresses { get; set; }
    }

    public class ForwardStoredMessageResult
    {
        public bool Success { get; set; }
        public string Id { get; set; }
        public List<WdForwardedMessageInfo> Forwarded { get; set; }
    }
}