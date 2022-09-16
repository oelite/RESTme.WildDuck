using System;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class SubmitStoredMessageRequest
    {
        public bool? DeleteFiles { get; set; }
        public DateTime SendTime { get; set; }
    }

    public class SubmitStoredMessageResult : WdBaseResponse
    {
        public string QueueId { get; set; }

        public SubmittedStoredMessage Message { get; set; }


        public class SubmittedStoredMessage
        {
            public long Id { get; set; }
            public string Mailbox { get; set; }
        }
    }
}