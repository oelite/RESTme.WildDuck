namespace RESTme.WildDuck.Models.Dkim.TransferObjects
{
    public class ListDkimRequest
    {
        public string Query { get; set; }
        public int? Limit { get; set; }
        public int? Page { get; set; }
        public int? Next { get; set; }
        public int? Previous { get; set; }
    }
}