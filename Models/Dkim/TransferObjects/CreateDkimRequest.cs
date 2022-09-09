namespace OElite.Restme.WildDuck.Models.Dkim.TransferObjects
{
    public class CreateDkimRequest
    {
        public string Domain { get; set; }
        public string Selector { get; set; }
        public string Description { get; set; }
        public string PrivateKey { get; set; }
    }

    public class DkimInfoResult : DkimInfo
    {
        public bool Success { get; set; }
    }
}