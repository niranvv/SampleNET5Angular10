namespace API.Helpers
{
    public class UserParams : PaginatedParams
    {
        public string CurrentUsername { get; set; }
        public string Gender { get; set; }

        public int MiNAge { get; set; }=18;
        public int MaxAge { get; set; }=150;
        public string OrderBy { get; set; }="lastActive";
    }
}