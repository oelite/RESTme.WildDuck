using System;

namespace OElite.Restme.WildDuck.Models.ApplicationPasswords
{
    public class WdAspInfo : WdBaseEntity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string[] Scopes { get; set; }
        public WdAspEvent LastUse { get; set; }
        public DateTime Created { get; set; }
    }

    public class WdAspEvent : WdBaseEntity
    {
        public DateTime Time { get; set; }
        public string Event { get; set; }
    }
}