namespace OElite.Restme.WildDuck.Models.Mailbox.TransferObjects
{
    public class UpdateMailboxRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public string Path { get; set; }
        public int Retention { get; set; }
        public bool Subscribed { get; set; }
    }
}