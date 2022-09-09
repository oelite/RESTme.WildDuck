namespace OElite.Restme.WildDuck.Models.Filters.TransferObjects
{
    public class CreateFilterRequest : WdFilterInfo
    {
        public string User { get; set; }
    }

    public class CreateFilterResult : WdBaseResponse
    {
        public string Id { get; set; }
    }
}