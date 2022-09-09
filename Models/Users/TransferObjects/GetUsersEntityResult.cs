namespace OElite.Restme.WildDuck.Models.Users.TransferObjects
{
    public class GetUsersEntityResult : WdBaseEntity
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string[] Tags { get; set; }
        public string[] Targets { get; set; }
        public string[] Enabled2fa { get; set; }
        public bool Autoreply { get; set; }
        public bool EncryptMessages { get; set; }
        public bool EncryptForwarded { get; set; }
        public WdUserQuotaInfo Quota { get; set; }
        public bool HasPasswordSet { get; set; }
        public bool Activated { get; set; }
        public bool Disabled { get; set; }
        public bool Suspended { get; set; }
    }
}