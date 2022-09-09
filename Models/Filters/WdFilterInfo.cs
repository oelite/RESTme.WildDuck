namespace OElite.Restme.WildDuck.Models.Filters
{
    public class WdFilterInfo
    {
        public string Name { get; set; }
        public WdFilterQuery Query { get; set; }
        public WdFilterAction Action { get; set; }
        public bool? Disabled { get; set; }
    }

    public class WdFilterQuery
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string ListId { get; set; }
        public string Text { get; set; }
        public bool? Ha { get; set; }
        public long Size { get; set; }
    }

    public class WdFilterAction
    {
        public bool? Seen { get; set; }
        public bool? Flag { get; set; }
        public bool? Delete { get; set; }
        public bool? Spam { get; set; }
        public string Mailbox { get; set; }
        public string[] Targets { get; set; }
    }
}