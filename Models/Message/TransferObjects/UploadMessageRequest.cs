using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class UploadMessageRequest
    {
        public bool? Unseen { get; set; }
        public bool? Draft { get; set; }
        public bool? Flagged { get; set; }
        public string Raw { get; set; }
        public WdMessageAddress From { get; set; }
        public WdMessageAddress[] To { get; set; }
        public WdMessageAddress[] Cc { get; set; }
        public WdMessageAddress[] Bcc { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Html { get; set; }
        public KeyValuePair<string, string>[] Headers { get; set; }
        public new WdMessageAttachmentUpload[] Attachments { get; set; }
        public new string[] Files { get; set; }
        public object Reference { get; set; }
        public object MetaData { get; set; }
        public string Sess { get; set; }
        public string Ip { get; set; }

        public ReplaceMessage ReplacePrevious { get; set; }

        public class ReplaceMessage
        {
            public long Id { get; set; }
            public string Mailbox { get; set; }
        }
    }


    public class UploadMessageResponse : WdBaseResponse
    {
        public UploadedMessageInfo Message { get; set; }

        public class UploadedMessageInfo
        {
            public long Id { get; set; }
            public string Mailbox { get; set; }
        }
    }
}