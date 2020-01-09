namespace RESTme.WildDuck.Models.Users.TransferObjects
{
    public class GetUsersRequest
    {
        /// <summary>
        /// Partial match of username or default email address
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Comma separated list of tags. The User must have at least one to be set
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// Comma separated list of tags. The User must have all listed tags to be set
        /// </summary>
        public string RequiredTags { get; set; }

        /// <summary>
        /// How many records to return
        /// Default value: 20
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Cursor value for next page, retrieved from nextCursor response value
        /// </summary>
        public int Next { get; set; }

        /// <summary>
        /// Cursor value for previous page, retrieved from previousCursor response value
        /// </summary>
        public int Previous { get; set; }
    }
}