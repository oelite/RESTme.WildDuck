namespace RESTme.WildDuck.Models.Authentication
{
    public class WdUserAuthInfo
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Scope { get; set; }
        public string Require2fa { get; set; }
        public bool RequirePasswordChange { get; set; }
        public string Token { get; set; }
    }
}