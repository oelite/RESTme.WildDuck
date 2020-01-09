namespace RESTme.WildDuck.Models.ApplicationPasswords.TransferObjects
{
    public class NewApplicationPasswordRequest
    {
        public string User { get; set; }
        public string Description { get; set; }
        public string[] Scopes { get; set; }
        public bool? GenerateMobileconfig { get; set; }
        public string Address { get; set; }
        public int? Ttl { get; set; }
        public string Sess { get; set; }
        public string Ip { get; set; }
    }

    public class NewApplicationPasswordResult : WdBaseResponse
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Mobileconfig { get; set; }
    }
}