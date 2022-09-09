namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class RestoreMessagesRequest
    {
        public string User { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}