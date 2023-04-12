namespace OElite.Restme.WildDuck.Models.Message.TransferObjects;

public class DeleteMessageRequest
{
    public string MailboxId { get; set; }
    public long MessageId { get; set; }
}
