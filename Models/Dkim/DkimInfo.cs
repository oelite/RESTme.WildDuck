namespace RESTme.WildDuck.Models.Dkim
{
    public class DkimInfo : WdBaseEntity
    {
        public string Id { get; set; }
        public string Domain { get; set; }
        public string Selector { get; set; }
        public string Description { get; set; }
        public string Fingerprint { get; set; }
        public string PublicKey { get; set; }
        public DkimInfoDnsSetting DnsTxt { get; set; }
        public string Created { get; set; }
    }

    public class DkimInfoDnsSetting
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}