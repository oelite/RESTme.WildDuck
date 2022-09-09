namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class SubmitStoredMessageRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public string Message { get; set; }
        public bool? DeleteFiles { get; set; }
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