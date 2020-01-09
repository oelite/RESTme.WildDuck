using System.Globalization;

namespace RESTme.WildDuck.Models.Message.TransferObjects
{
    public class DeleteMessagesResult : WdBaseResponse
    {
        public long Deleted { get; set; }
    }
}