namespace RESTme.WildDuck.Models.Mailbox
{
    public class WdMailboxInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string SpecialUse { get; set; }
        public int ModifyIndex { get; set; }
        public bool Subscribed { get; set; }
        public long Total { get; set; }
        public long Unseen { get; set; }
    }
}