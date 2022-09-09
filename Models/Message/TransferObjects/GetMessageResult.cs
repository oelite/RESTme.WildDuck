using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class GetMessageResult : WdMessageDetail
    {
        public bool Success { get; set; }
        public string Error { get; set; }


        public string User { get; set; }

        public WdMessageEnvelope Envelop { get; set; }
        public string MessageId { get; set; }
        public string Date { get; set; }
        public WdMessageMailingList List { get; set; }
        public string Expires { get; set; }

        public string[] Html { get; set; }
        public string Text { get; set; }

        public WdMessageVerificationResult VerificationResults { get; set; }

        public string MetaData { get; set; }
        public string Reference { get; set; }

        /// <summary>
        /// List of files added to this message as attachments. Applies to Drafts, normal messages do not have this property. Needed to prevent uploading the same attachment every time a draft is updated
        /// </summary>
        public List<WdMessageFileInfo> Files { get; set; }
    }
}