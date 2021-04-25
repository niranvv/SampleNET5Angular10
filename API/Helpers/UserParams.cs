namespace API.Helpers
{
    public class UserParams
    {
        private int _pageSize = 10;
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string CurrentUsername { get; set; }
        public string Gender { get; set; }

        public int MiNAge { get; set; }=18;
        public int MaxAge { get; set; }=150;
        

    }
}