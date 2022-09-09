using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.ApplicationPasswords.TransferObjects
{
    public class ListApplicationResult : WdBaseResponse
    {
        public List<WdAspInfo> Results { get; set; }
    }
}