namespace Xackathon.Web.Models
{
    public class RequestViewModel
    {
        public long Id { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public ProfileViewModel Profile { get; set; }
        public IEnumerable<MediaContentViewModel> Content { get; set; }
        public IEnumerable<ProblemCategoryViewModel> ProblemCategories { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public int Rating { get; set; }
        public int WatchCount { get; set; }
        public string CreatedAt { get; set; }
    }
}
