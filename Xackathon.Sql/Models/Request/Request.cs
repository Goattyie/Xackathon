using Xackathon.Abstractions;

namespace Xackathon.Dal.Models
{
    public class Request
    {
        public long Id { get; set; }
        public long ProfileId { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Description { get; set; }
        public Source Source { get; set; }
        public int Rating { get; set; }
        public int WatchCount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Profile Profile { get; set; }
        public IEnumerable<MediaContent> MediaContent { get; set; }
        public IEnumerable<ProblemCategory> ProblemCategories { get; set; }
    }
}
