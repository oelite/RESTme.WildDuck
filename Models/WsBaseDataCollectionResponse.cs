using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OElite.Restme.WildDuck.Models
{
    public class WdBaseEntityCollectionResponse<T> where T : WdBaseEntity
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        
        public int Total { get; set; }
        public int Page { get; set; }
        public string PreviousCursor { get; set; }
        public string NextCursor { get; set; }
        public List<T> Results { get; set; }
    }
}