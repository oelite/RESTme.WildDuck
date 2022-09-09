namespace RESTme.WildDuck.Models.Message.TransferObjects
{
    public class GetMessagesSearchRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public string Thread { get; set; }
        public string Query { get; set; }
        public string Datestart { get; set; }
        public string Dateend { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public bool? Attachments { get; set; }
        public bool? Flagged { get; set; }
        public bool? Unseen { get; set; }
        public int Limit { get; set; }
        public int Page { get; set; }
        public int Next { get; set; }
        public int Previous { get; set; }
    }
}