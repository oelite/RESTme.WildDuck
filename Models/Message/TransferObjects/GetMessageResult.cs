using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Message.TransferObjects
{
    public class GetMessageResult : WdMessageDetail
    {
        public bool Success { get; set; }
        public string Error { get; set; }
    }
    
    
    
}