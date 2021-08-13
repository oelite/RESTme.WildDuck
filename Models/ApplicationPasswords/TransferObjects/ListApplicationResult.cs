using System.Collections.Generic;

namespace RESTme.WildDuck.Models.ApplicationPasswords.TransferObjects
{
    public class ListApplicationResult : WdBaseResponse
    {
        public List<WdAspInfo> Results { get; set; }
    }
}