namespace RESTme.WildDuck.Models.Users
{
    public class WdUserInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// If provided then validates against account password before applying any changes
        /// </summary>
        public string ExistingPassword { get; set; }

        /// <summary>
        /// New password for the account. Set to boolean false to disable password usage
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// If true then password is already hashed, so store as. Hash needs to be bcrypt $2a, $2y or $2b. Additionally md5-crypt hashes $1 are allowed but these are rehashed on first successful authentication
        /// </summary>
        public string HashedPassword { get; set; }

        /// <summary>
        /// If false then validates provided passwords against Have I Been Pwned API. Experimental, so validation is disabled by default but will be enabled automatically in some future version of WildDuck.
        /// Default: true
        /// </summary>
        public bool AllowUnsafe { get; set; }

        public string[] Tags { get; set; }

        /// <summary>
        /// Default retention time in ms. Set to 0 to disable
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// If true then all messages sent through MSA are also uploaded to the Sent Mail folder. Might cause duplicates with some email clients, so disabled by default.
        /// </summary>
        public bool UploadSentMessages { get; set; }

        /// <summary>
        /// If true then received messages are encrypted
        /// </summary>
        public bool EncryptMessages { get; set; }

        /// <summary>
        /// If true then forwarded messages are encrypted
        /// </summary>
        public bool EncryptForwarded { get; set; }

        /// <summary>
        /// Public PGP key for the User that is used for encryption. Use empty string to remove the key
        /// </summary>
        public string PubKey { get; set; }

        public string MetaData { get; set; }

        /// <summary>
        /// Language code for the User
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// An array of forwarding targets. The value could either be an email address or a relay url to next MX server ("smtp://mx2.zone.eu:25") or an URL where mail contents are POSTed to
        /// </summary>
        public string[] Targets { get; set; }

        /// <summary>
        /// Relative scale for detecting spam. 0 means that everything is spam, 100 means that nothing is spam
        /// </summary>
        public int SpamLevel { get; set; }

        /// <summary>
        /// Allowed quota of the user in bytes
        /// </summary>
        public long Quota { get; set; }

        /// <summary>
        /// How many messages per 24 hour can be sent
        /// </summary>
        public int Recipients { get; set; }

        /// <summary>
        /// How many messages per 24 hour can be forwarded
        /// </summary>
        public int Forwards { get; set; }

        /// <summary>
        /// How many bytes can be uploaded via IMAP during 24 hour
        /// </summary>
        public long ImapMaxUpload { get; set; }

        /// <summary>
        /// How many bytes can be downloaded via IMAP during 24 hour
        /// </summary>
        public long ImapMaxDownload { get; set; }

        /// <summary>
        /// How many bytes can be downloaded via POP3 during 24 hour
        /// </summary>
        public long ImapMaxConnections { get; set; }

        /// <summary>
        /// How many messages can be received from MX during 60 seconds
        /// </summary>
        public int ReceiveMax { get; set; }

        /// <summary>
        /// If true, then disables 2FA for this user
        /// </summary>
        public bool Disable2fa { get; set; }

        /// <summary>
        /// List of scopes that are disabled for this user ("imap", "pop3", "smtp")
        /// </summary>
        public string[] DisabledScopes { get; set; }

        public bool Suspended { get; set; }

        public string Sess { get; set; }

        public string Ip { get; set; }
    }
}