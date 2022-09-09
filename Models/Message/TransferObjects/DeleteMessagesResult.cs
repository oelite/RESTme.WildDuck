using System.Globalization;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class DeleteMessagesResult : WdBaseResponse
    {
        public long Deleted { get; set; }
    }
}