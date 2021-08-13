namespace RESTme.WildDuck.Models.Mailbox.TransferObjects
{
    public class CreateMailboxRequest
    {
        public string User { get; set; }

        /// <summary>
        /// Full path of the mailbox, folders are separated by slashes, ends with the mailbox name (unicode string)
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        public int Retention { get; set; }
    }

    public class CreateMailboxResult : WdBaseResponse
    {
        public string Id { get; set; }
    }
}