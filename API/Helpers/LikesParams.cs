namespace API.Helpers
{
    public class LikesParams : PaginatedParams
    {
        public int UserId { get; set; }
        public string Predicate { get; set; }
    }
}