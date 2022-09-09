namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class UploadMessageRequest : WdMessageDetail
    {
        public string User { get; set; }
        public bool? Unseen { get; set; }
    }

    public class UploadMessageResponse : WdBaseResponse
    {
        public UploadedMessageInfo Message { get; set; }

        public class UploadedMessageInfo
        {
            public long Id { get; set; }
            public string Mailbox { get; set; }
        }
    }
}