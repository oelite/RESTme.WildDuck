namespace OElite.Restme.WildDuck.Models.Authentication.TransferObjects
{
    public class AuthenticateUserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Protocol { get; set; }
        public string Scope { get; set; }
        public bool? Token { get; set; }
        public string Sess { get; set; }
        public string Ip { get; set; }
    }

    public class AuthenticateUserResult : WdUserAuthInfo
    {
        public bool Success { get; set; }
    }
}