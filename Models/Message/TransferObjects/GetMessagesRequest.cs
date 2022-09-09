using System.Collections.Generic;
using System.Globalization;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class GetMessagesRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public bool Unseen { get; set; }
        public int Limit { get; set; }
        public string Order { get; set; }
        public int Next { get; set; }
        public int Previous { get; set; }
    }
}