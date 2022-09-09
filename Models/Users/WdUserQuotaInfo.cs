namespace OElite.Restme.WildDuck.Models.Users
{
    public class WdUserQuotaInfo
    {
        /// <summary>
        /// Allowed quota of the user in bytes
        /// </summary>
        public long Allowed { get; set; }

        /// <summary>
        /// Space used in bytes
        /// </summary>
        public long Used { get; set; }
    }
}