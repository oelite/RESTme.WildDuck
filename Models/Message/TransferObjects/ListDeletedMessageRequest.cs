namespace RESTme.WildDuck.Models.Message.TransferObjects
{
    public class ListDeletedMessageRequest
    {
        public string User { get; set; }
        public int? Limit { get; set; }
        public int? Page { get; set; }
        public int? Order { get; set; }
        public int? Next { get; set; }
        public int? Previous { get; set; }
    }
}