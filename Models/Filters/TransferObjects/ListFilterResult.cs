using System.Collections.Generic;

namespace OElite.Restme.WildDuck.Models.Filters.TransferObjects
{
    public class ListFilterResult
    {
        public bool Success { get; set; }
        public List<ListFilterResultItem> Results { get; set; }
    }

    public class ListFilterResultItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Created { get; set; }
        public List<string[]> Query { get; set; }
        public List<string[]> Action { get; set; }
        public bool Disabled { get; set; }
    }
}