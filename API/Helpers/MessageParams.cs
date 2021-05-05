namespace API.Helpers
{
    public class MessageParams : PaginatedParams
    {
        public string Username { get; set; }
        public string Container { get; set; } = "unread";

    }
}