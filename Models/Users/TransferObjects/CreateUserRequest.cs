namespace OElite.Restme.WildDuck.Models.Users.TransferObjects
{
    public class CreateUserRequest : WdUserInfo
    {
        public string Username { get; set; }

        /// <summary>
        /// Optional. Display Name
        /// </summary>
        public string Name { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        public string HashedPassword { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        public bool AllowUnsafe { get; set; }

        /// <summary>
        /// Default Email Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        public bool EmptyAddress { get; set; }

        /// <summary>
        /// Optional
        /// </summary>

        public bool RequirePasswordChange { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        public WdDefinedMailboxes Mailboxes { get; set; }
    }

}