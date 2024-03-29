using System;
using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Message
{
    public class WdMessageBaseInfo : WdBaseEntity
    {
        public long Id { get; set; }
        public string Mailbox { get; set; }
        public string Thread { get; set; }
        public WdMessageAddress From { get; set; }
        public List<WdMessageAddress> To { get; set; }
        public List<WdMessageAddress> Cc { get; set; }
        public List<WdMessageAddress> Bcc { get; set; }
        public string Subject { get; set; }
        public string Intro { get; set; }
        public bool? Attachments { get; set; }
        public bool? Seen { get; set; }
        public bool? Deleted { get; set; }
        public bool? Draft { get; set; }
        public bool? Flagged { get; set; }
        public bool? Answered { get; set; }
        public bool? Forwarded { get; set; }
        public DateTime Date { get; set; }
        public DateTime IDate { get; set; }
        public long Size { get; set; }


        public List<KeyValuePair<string, string>> Headers { get; set; }
        public WdMessageContentType ContentType { get; set; }
    }

    public class WdMessageDetail : WdMessageBaseInfo
    {
        public string User { get; set; }

        public WdMessageEnvelope Envelop { get; set; }
        public string MessageId { get; set; }
        public WdMessageMailingList List { get; set; }
        public string Expires { get; set; }

        public string[] Html { get; set; }
        public string Text { get; set; }

        public WdMessageVerificationResult VerificationResults { get; set; }

        public object MetaData { get; set; }
        public object[] References { get; set; }

        public new List<WdMessageAttachment> Attachments { get; set; }

        /// <summary>
        /// List of files added to this message as attachments. Applies to Drafts, normal messages do not have this property. Needed to prevent uploading the same attachment every time a draft is updated
        /// </summary>
        public List<WdMessageFileInfo> Files { get; set; }
    }

    public class WdMessageAddress : WdBaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class WdMessageContentType : WdBaseEntity
    {
        public string Value { get; set; }
        public Dictionary<string, string> Params { get; set; }
    }

    public class WdMessageEnvelope : WdBaseEntity
    {
        public string From { get; set; }
        public List<WdMessageEnvelopeRcpt> Rcpt { get; set; }
    }

    public class WdMessageEnvelopeRcpt : WdBaseEntity
    {
        public string Value { get; set; }
        public string Formatted { get; set; }
    }

    public class WdMessageMailingList : WdBaseEntity
    {
        public string Id { get; set; }
        public string Unsubscribe { get; set; }
    }

    public class WdMessageAttachment : WdBaseEntity
    {
        public string Id { get; set; }
        public string Cid { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Disposition { get; set; }
        public string TransferEncoding { get; set; }
        public bool Related { get; set; }
        public long SizeKb { get; set; }
    }

    public class WdMessageAttachmentUpload : WdBaseEntity
    {
        public string Cid { get; set; }
        public string Content { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
    }

    public class WdMessageVerificationResult : WdBaseEntity
    {
        public WdMessageTlsVerificationResult Tls { get; set; }
        public string Spf { get; set; }
        public string Dkim { get; set; }

        public class WdMessageTlsVerificationResult
        {
            public string Name { get; set; }
            public string Version { get; set; }
        }
    }

    public class WdMessageFileInfo : WdBaseEntity
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
    }
}