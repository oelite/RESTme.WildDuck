namespace RESTme.WildDuck.Models.Message.TransferObjects
{
    public class RestoreMessageRequest
    {
        public string User { get; set; }
        public long Message { get; set; }
        public string Mailbox { get; set; }
    }

    public class RestoreMessageResult
    {
        public bool Success { get; set; }
        public string Mailbox { get; set; }
        public long Id { get; set; }
    }
}