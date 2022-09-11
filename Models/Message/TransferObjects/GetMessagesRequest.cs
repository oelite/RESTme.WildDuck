using System.Collections.Generic;
using System.Globalization;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class GetMessagesRequest
    {
        public string User { get; set; }
        public string Mailbox { get; set; }
        public bool? Unseen { get; set; }
        public bool? MetaData { get; set; }
        public bool? ThreadCounters { get; set; }

        public int Limit { get; set; }
        public int Page { get; set; }
        public string Order { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
    }
}