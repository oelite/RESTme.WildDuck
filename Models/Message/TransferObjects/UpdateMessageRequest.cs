namespace RESTme.WildDuck.Models.Message.TransferObjects
{
    public class UpdateMessageRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public string Message { get; set; }
        public string MoveTo { get; set; }
        public bool? Seen { get; set; }
        public bool? Flagged { get; set; }
        public bool? Draft { get; set; }
        public string Expires { get; set; }
        public string MetaData { get; set; }
    }

    public class UpdateMessageResult : WdBaseResponse
    {
        public string Id { get; set; }
        public int Updated { get; set; }
    }
}